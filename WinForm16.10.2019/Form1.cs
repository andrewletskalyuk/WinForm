using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm16._10._2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            MonthCalendar mc = sender as MonthCalendar;
            SelectionRange range = mc.SelectionRange;

            label1.Text = range.Start.ToString("dddd, dd / MMMM / yyyy") + "\n" +
                range.End.ToString("dddd, dd / MMMM / yyyy");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker picker = sender as DateTimePicker;
            string season = "Winter";
            int month = picker.Value.Month;
            if (month >=3 && month<=5)
            {
                season = "Spring";
            }
            else if (month >=6 && month <=8)
            {
                season = "Summer";
            }
            else if (month >=9 && month <=11)
            {
                season = "Autumn";
            }
            label2.Text = season;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = (sender as DateTimePicker).Value.TimeOfDay.ToString();
        }
    }
}
