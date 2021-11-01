using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeLbl.Text = DateTime.Now.ToString("HH:mm");
            SecondsLbl.Text = DateTime.Now.ToString("ss");
            DateLbl.Text = DateTime.Now.ToString("MMM dd yyyy").ToUpper();
            DayLbl.Text = DateTime.Now.ToString("dddd").ToUpper();
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
