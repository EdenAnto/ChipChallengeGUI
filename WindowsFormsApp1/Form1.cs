using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            exportToVerilog();
            string message = "The file was created successfully";
            DialogResult res = MessageBox.Show(message);
            if (res == DialogResult.OK)
                this.Close();
        }

 

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void setRTC_CheckedChanged(object sender, EventArgs e)
        {
            if (setRTC.Checked)
            {
                DateTime t= DateTime.Now;
                setHourManual.Enabled = false;
                setMinManual.Enabled = false;
                setSecManual.Enabled = false;
                setHourManual.Value = t.Hour;
                setMinManual.Value = t.Minute;
                setSecManual.Value = t.Second;
            }
            else
            {
                setHourManual.Enabled = true;
                setMinManual.Enabled = true;
                setSecManual.Enabled = true;
            }
        }

        private void setRealDate_CheckedChanged(object sender, EventArgs e)
        {
            if (setRealDate.Checked)
            {
                dateTimePicker.Enabled = false;
                dateTimePicker.Value = GetLocalDate();
            }
            else
                dateTimePicker.Enabled = true;

        }

        #region MyFunctions
        private TimeSpan GetLocalTime()
        {
            DateTime localTime = DateTime.Now;
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan elapsedTime = localTime.ToUniversalTime() - unixEpoch;
            return elapsedTime;
        }
        private DateTime GetLocalDate()
        {
            return DateTime.Now;
        }

        private int getTimeInSec(DateTime lc) {
            return lc.Hour*3600 + lc.Minute*60 + lc.Second +120; //120 for compiling delay
        }

        private string getDayAsString(DateTime lc)
        {
            string day = lc.Day < 10 ? "" + 0 + lc.Day : ""+lc.Day;
            return "" + day;
        }
        private string getMonthAsString(DateTime lc)
        {
            string month = lc.Month < 10 ? "" + 0 + lc.Month : "" + lc.Month;
            return "" + month ;
        }
        private string getYearAsString(DateTime lc)
        {
            string year=(""+lc.Year).Substring(0,2);
            return "" + year;
        }
        private void exportToVerilog()
        {
            DateTime lc = GetLocalDate();
            int hour = Convert.ToInt32(setHourManual.Value);
            int minute = Convert.ToInt32(setMinManual.Value);
            int second = Convert.ToInt32(setSecManual.Value);

            string fileName = "RTC_executable.v"; // the name of the Verilog file to create
            if(!setRealDate.Checked)
            {
                hour = Convert.ToInt32(setHourManual.Value);
                minute=Convert.ToInt32(setMinManual.Value);
                second=Convert.ToInt32(setSecManual.Value);
                TimeSpan desiredTime = new TimeSpan(hour, minute, second);
                lc.Date.Add(desiredTime);
            }

            if (!setRTC.Checked) {
                lc = dateTimePicker.Value.Date.Add(new TimeSpan(hour, minute, second));

            }

            string data = getDataToFile(lc);

            // create a new Verilog file and write data to it
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(data);
            }

        }

        private string getDataToFile(DateTime lc)
        {
            int timeInSec = getTimeInSec(lc);
            string day = getDayAsString(lc);
            string month = getMonthAsString(lc);
            string year = getYearAsString(lc);
            int dateInNum = ((lc.Day-1) * 10000) + ((lc.Month-1) * 100) + lc.Year%100;


            // the data of the Verilog file to create
            string data = "module RTC_executable(" +
                          "\r\noutput [31:0] userTime," +
                          "\r\noutput [31:0] userDate" +
                          "\r\n);" +
                          "\r\n\r\n//This module written by getTime.exe" +
                          $"\r\n\r\nassign userTime={timeInSec};" +
                          $"\r\nassign userDate={dateInNum};" +
                          "\r\n\r\n\r\nendmodule";
            return data;
        } 

        #endregion

        private void SetHourManual_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void secSecManual_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
