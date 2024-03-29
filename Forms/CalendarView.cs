﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SoftwareTwoProject.Class;
using System.Windows.Forms;

namespace SoftwareTwoProject.Forms
{
    public partial class CalendarView : Form
    {
        public CalendarView()
        {
            InitializeComponent();

            

            // DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss") should be conversion to database
            //this fills the first table with the current list of appointments
            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();



            string appointmentsQuery = "select appointmentId, customerId, type, start" +
                " from appointment";

            MySqlCommand SQLappointmentcol = new MySqlCommand(appointmentsQuery, custtable);
            MySqlDataAdapter appointprep = new MySqlDataAdapter(SQLappointmentcol);
            DataTable AppointmentTableInfo = new DataTable();
            appointprep.Fill(AppointmentTableInfo);
            AppCalGrid.DataSource = AppointmentTableInfo;

            // NOTE: this is the code for localization that fills the table with updated times for appointments based on timezone
            for (int i = 0; i < AppCalGrid.Rows.Count; i++)
            {
                AppCalGrid.Rows[i].Cells[3].Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)AppCalGrid.Rows[i].Cells[3].Value, TimeZoneInfo.Local).ToString();


            }





            custtable.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainDashboard dash = new MainDashboard();
            dash.Show();
            this.Close();
        }

        

        private void UpdateBut_MouseClick(object sender, MouseEventArgs e)
        { 
            //this selects the date range and if you desire monthly or weekly views
             if (WeeklyBut.Checked == true)
            {
                DateTime WeekCal = dateTimePicker.Value;
                string WeekSQL = WeekCal.ToString("yyyy'-'MM'-'dd HH:mm:ss");
                string WeekSQL2 = WeekCal.ToString("yyyy'-'MM'-'dd");

                MessageBox.Show(WeekSQL);

                string x = Connection.connectstring;
                MySqlConnection custtable = new MySqlConnection(x);
                custtable.Open();



                string weeksQuery = "select appointmentId, customerId, type, start" +
                    $" from appointment where WEEK(DATE(start)) = WEEK('{WeekSQL2}') AND YEAR(DATE(start)) = YEAR('{WeekSQL2}')";

                MySqlCommand SQLappointmentcol = new MySqlCommand(weeksQuery, custtable);
                MySqlDataAdapter appointprep = new MySqlDataAdapter(SQLappointmentcol);
                DataTable AppointmentTableInfo = new DataTable();
                appointprep.Fill(AppointmentTableInfo);
                AppCalGrid.DataSource = AppointmentTableInfo;

                custtable.Close();

            }
             else if (MonthBut.Checked == true)
            {
                DateTime WeekCal = dateTimePicker.Value;
                string MonthSQL = WeekCal.ToString("yyyy'-'MM'-'dd HH:mm:ss");
                string MonthSQL2 = WeekCal.ToString("yyyy'-'MM'-'dd");

                MessageBox.Show(MonthSQL);

                string x = Connection.connectstring;
                MySqlConnection custtable = new MySqlConnection(x);
                custtable.Open();



                string weeksQuery = "select appointmentId, customerId, type, start" +
                    $" from appointment where MONTH(DATE(start)) = MONTH('{MonthSQL2}') AND YEAR(DATE(start)) = YEAR('{MonthSQL2}')";

                MySqlCommand SQLappointmentcol = new MySqlCommand(weeksQuery, custtable);
                MySqlDataAdapter appointprep = new MySqlDataAdapter(SQLappointmentcol);
                DataTable AppointmentTableInfo = new DataTable();
                appointprep.Fill(AppointmentTableInfo);
                AppCalGrid.DataSource = AppointmentTableInfo;
                
                
                if(AppCalGrid.Rows.Count>0)
                {
                    for (int i = 0; i < AppCalGrid.Rows.Count; i++)
                    {
                        AppCalGrid.Rows[i].Cells[3].Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)AppCalGrid.Rows[i].Cells[3].Value, TimeZoneInfo.Local).ToString(); ;

                    }

                }
                
                
                

                custtable.Close();

            }
        }
    }
}
