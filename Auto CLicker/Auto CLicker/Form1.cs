using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_CLicker
{
    public partial class Form1 : Form
    {
        int MSPass;
        int UntilStartsThing;
        public Form1()
        {
            InitializeComponent();
        }
        private const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const UInt32 MOUSEEVENTF_LEFTUP = 0x0004;
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInf);
        private void ClickM()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);//make left button down
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);//make left button up
        }
        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                int Miliseconds = int.Parse(MS.Text);
                timer1.Interval = Miliseconds;
                timer2.Interval = 1000;
                UntilStartsThing = 5;
                UntilStarts.Text = UntilStartsThing.ToString();
                timer2.Start();
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is ArgumentOutOfRangeException)
                MS_Thing.Text = "input a valid number. it will be the miliseconds interval thing.";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            MSPass++;
            TotalAutoClicks.Text = MSPass.ToString();
            ClickM();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (UntilStartsThing != 0)
            {
                UntilStartsThing--;
            }
            else
            {
                timer2.Stop();
                timer1.Start();
            }
            UntilStarts.Text = UntilStartsThing.ToString();

        }
    }
}
