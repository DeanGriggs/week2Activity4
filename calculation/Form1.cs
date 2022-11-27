using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
           String f = tbNumber.Text;
            Console.WriteLine(f.GetType());
            int i=Int32.Parse(f);
            double ii=Double.Parse(f);
            double decdec = 0;
            double yryr = 0;
            double dayday = 0;
            double hrhr = 0;
            double minmin = 0;
            double secsec = 0;
            int dec = 0;
            int yr = 0;
            int day = 0;
            int hr = 0;
            int min = 0;
            int sec = 0;

            if (i < 60)
            {
                label3.Text = (i) + " Seconds";
            }
            else if (i >= 60 && i < 3600)
            {
                min = i / 60;
                sec = i % 60;
                label3.Text = min + " Minutes" + " and " + sec + " Seconds";
            }
            else if (i >= 3600 && i < 86400)
            {
                hr = i / 3600;
                min = i % 3600 / 60;
                sec = i % 3600 % 60;
                label3.Text = hr + " Hour[s]" + " and " + min + " Minute[s]" + " and " + sec + " Second[s]";
            }
            else if (i >= 86400 && i < 31536000)
            {
                
                    day = i / 86400;
                    hr = i % 86400 / 3600;
                    min = i % 86400 % 3600 / 60;
                    sec = i % 86400 % 3600 % 60;
                    label3.Text = day + " Day[s]" + " and " + hr + " Hour[s]" + " and " + min + " Minute[s]" + " and " + sec + " Second[s]";
            }
            else if (i >= 31536000 && i < 315360000)
            {
                yr = i / 31536000;
                day = i % 31536000 / 86400;
                hr = i % 31536000 % 86400 / 3600;
                min = i % 31536000 % 86400 % 3600 / 60;
                sec = i % 31536000 % 86400 % 3600 % 60;
                label3.Text = yr + " Year[s]" + " and " + day + " Day[s]" + " and " + hr + " Hour[s]" + " and " + min + " Minute[s]" + " and " + sec + " Second[s]";
            }
            else if (i >= 315360000 && ii < 3153600000)
            {
                decdec = ii / 315360000;
                yryr = ii % 315360000 / 31536000;
                dayday = ii % 315360000 % 31536000 / 86400;
                hrhr = ii % 315360000 % 31536000 % 86400 / 3600;
                minmin = ii % 315360000 % 31536000 % 86400 % 3600 / 60;
                secsec = ii % 315360000 % 31536000 % 86400 % 3600 % 60;
                dec = (int)decdec;
                yr = (int)yryr;
                day = (int)dayday;
                hr = (int)hrhr;
                min = (int)minmin;
                sec = (int)secsec;


                label3.Text = dec + " Decade[s]" + " and " + yr + " Year[s]" + " and " + day + " Day[s]" + " and " + hr + " Hour[s]" + " and " + min + " Minute[s]" + " and " + sec + " Second[s]";
                   label4.Text =  " But for real no more. You're gonna break me.";
            }
            else
            {
                label3.Text = "error";
            }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNumber.Text = "";
            label3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbNumber.Text = "";
            label3.Text = "";
            label4.Text = "";
        }
    }
    }

