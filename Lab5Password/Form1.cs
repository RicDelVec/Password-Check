using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
                lblOutput.Text = "Password accepted. Please continue.";
            else
                lblOutput.Text = "Incorrect password. Please try again.";
        }
    }
}
