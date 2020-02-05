using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestownikWindowsFormsAPP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Test openTestForm = new Test();
            openTestForm.Show();
            this.Hide();
            openTestForm.CountOfRepetitons = countOfRepeatsComboBox.SelectedIndex;
            openTestForm.WhileFail = whileFailComboBox.SelectedIndex;
            openTestForm.LoadQuestion();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

    }
}
