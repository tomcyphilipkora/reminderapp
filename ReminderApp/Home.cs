using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderApp
{
    public partial class Home : Form
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-0M7JDPE;initial catalog=ReminderApp;integrated security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int id = 0;

        public Home()
        {
            InitializeComponent();
            DisplayReminderData();
            DataGridViewColumn c0 = dgvReminderDetails.Columns[0];
            c0.Visible = false;
            DataGridViewColumn c1 = dgvReminderDetails.Columns[1];
            c1.Width = 150;
            DataGridViewColumn c2 = dgvReminderDetails.Columns[2];
            c2.Width = 243;
            DataGridViewColumn c3 = dgvReminderDetails.Columns[3];
            c3.Width = 150;
            DataGridViewColumn c4 = dgvReminderDetails.Columns[4];
            c4.Width = 150;

            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(1);

            var timer = new System.Threading.Timer((e) =>
            {
                DisplayReminderPopup();
            }, null, startTimeSpan, periodTimeSpan);
        }

        private void DisplayReminderPopup()
        {
            DateTime now = DateTime.Now;
            string date = now.ToString("yyyy-MM-dd");
            string time = now.Hour + ":" + now.Minute;
            string msg = "", title = "";
            con.Open();
            cmd = new SqlCommand("select [ReminderHeading] AS Heading, [ReminderBody] AS Body from [dbo].[Reminder] WHERE RemDate = @date AND RemTime=@time", con);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                msg = reader["Body"].ToString();
                title = reader["Heading"].ToString();
            }

            con.Close();
            
            MessageBox.Show(msg, title);
        }

        private void DisplayReminderData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select [ReminderID], [ReminderHeading] AS Heading, [ReminderBody] AS Body, [RemDate] AS Date, [RemTime] AS Time from [dbo].[Reminder]", con);
            adapt.Fill(dt);
            dgvReminderDetails.DataSource = dt;
            con.Close();  
        }

        private void Home_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                this.cbHour.Items.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                this.cbMin.Items.Add(i);
            }

            this.cbAMPM.Items.Add("AM");
            this.cbAMPM.Items.Add("PM");
        }

        private void dgvReminderDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dgvReminderDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtHeading.Text = dgvReminderDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBody.Text = dgvReminderDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpDate.Value = Convert.ToDateTime(dgvReminderDetails.Rows[e.RowIndex].Cells[3].Value);
            int hour = Convert.ToDateTime(dgvReminderDetails.Rows[e.RowIndex].Cells[4].Value.ToString()).Hour - 1;
            int min = Convert.ToDateTime(dgvReminderDetails.Rows[e.RowIndex].Cells[4].Value.ToString()).Minute;
            int amPmIndex = 1;

            if (hour > 12)
            {
                hour = hour - 12;
                amPmIndex = 2;
            }
            cbHour.SelectedIndex = hour == -1 ? 11 : hour;
            cbMin.SelectedIndex = min;
            cbAMPM.SelectedIndex = amPmIndex;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                insertReminder();
            }
            else
            {
                MessageBox.Show("Please enter all value");
            }
        }

        private void insertReminder()
        {
            string hour = "";
            if (cbAMPM.Text == "PM")
            {
                hour = (Convert.ToInt32(cbHour.Text) + 12).ToString();
            }
            else
            {
                hour = cbHour.Text;
            }
            string time = hour + ":" + cbMin.Text;

            cmd = new SqlCommand("insert into [dbo].[Reminder]([ReminderHeading],[ReminderBody],[RemDate],[RemTime]) values(@heading,@body,@date,@time)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@heading", txtHeading.Text);
            cmd.Parameters.AddWithValue("@body", txtBody.Text);
            cmd.Parameters.AddWithValue("@date", dtpDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@time", time);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            DisplayReminderData();
            ClearData(); 
        }

        private void ClearData()
        {
            cbHour.SelectedIndex = -1;
            cbMin.SelectedIndex = -1;
            cbAMPM.SelectedIndex = -1;
            txtHeading.Text = "";
            txtBody.Text = "";
        }

        private bool ValidateInput()
        {
            bool status = false, dateStatus = false, houratatus = false, minStatus = false, amPmStatus = false;
            bool headingStatus = false, bodyStatus = false;

            if (dtpDate.Value.Date != null)
            {
                dateStatus = true;
            }
            if (cbHour.SelectedIndex != -1)
            {
                houratatus = true;
            }
            if (cbMin.SelectedIndex != -1)
            {
                minStatus = true;
            }
            if (cbAMPM.SelectedIndex != -1)
            {
                amPmStatus = true;
            }
            if (txtHeading.Text != null)
            {
                headingStatus = true;
            }
            if (txtBody.Text != null)
            {
                bodyStatus = true;
            }

            if (dateStatus && houratatus && minStatus && amPmStatus && headingStatus && bodyStatus)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            return status;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please Select Record to Update");
            }
            else if (ValidateInput())
            {
                string hour = "";
                if (cbAMPM.Text == "PM")
                {
                    hour = (Convert.ToInt32(cbHour.Text) + 12).ToString();
                }
                if (cbAMPM.Text == "AM" && Convert.ToInt32(cbHour.Text)==12)
                {
                    hour = (Convert.ToInt32(cbHour.Text) - 12).ToString();
                }
                else
                {
                    hour = cbHour.Text;
                }
                string time = hour + ":" + cbMin.Text;

                cmd = new SqlCommand("update [dbo].[Reminder] set [ReminderHeading]=@heading,[ReminderBody]=@body,[RemDate]=@date,[RemTime]=@time WHERE [ReminderID]=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@heading", txtHeading.Text);
                cmd.Parameters.AddWithValue("@body", txtBody.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@time", time);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully");
                DisplayReminderData();
                ClearData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    cmd = new SqlCommand("delete from [dbo].[Reminder] where ReminderID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayReminderData();
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }  
        } 

    }
}
