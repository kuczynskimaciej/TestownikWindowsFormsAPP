using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestownikWindowsFormsAPP.Views
{
    public partial class Finish : Form
    {
        public int Sec { get; set; }
        public int Mins { get; set; }
        public int Hours { get; set; }
        public Finish()
        {
            InitializeComponent();
        }
        private void End(object sender, EventArgs e)
        {
            TimeOfTestLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", Hours, Mins, Sec);
        }
        private void FinishButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
