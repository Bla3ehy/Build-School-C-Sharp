using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leapYear02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime StartDate = new DateTime(int.Parse(textBox1.Text), 1, 1);
            DateTime EndDate = StartDate.AddYears(1);

            int SaturdayCount = 0;
            int SundayCount = 0;
            while(StartDate <　EndDate)
            {
                if(StartDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    SaturdayCount += 1;
                }
                else if(StartDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    SundayCount += 1;
                }

                StartDate = StartDate.AddDays(1);
            }
            label1.Text = $@"{textBox1.Text}年 + 有{SaturdayCount}天星期六 + {SundayCount}天星期天";
        }
    }
}
