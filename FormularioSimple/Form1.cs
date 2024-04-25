using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btValidate_Click(object sender, EventArgs e)
        {
            //Step1: Validate both passwords are the same
            //Step2: Validate the password has 12 characters
            //      Capital letters, 3 special symbols and at least 1 number.
            string firtsPassword = textFirstPassword.Text;
            string secondPassword = textSecondPassword.Text;
            string regexPattern = @"^(?=(?:[^A-Z]*[A-Z]){1})(?=(?:[^a-z]*[a-z]){1})(?=(?:\D*\d){1})(?=(?:[^\W_]*[\W_]){3}[^\W_]*$)[A-Za-z\d\W_]{12}$";
            if (!firtsPassword.Equals(secondPassword))
            {
                MessageBox.Show("The Passwords are not the same", "Validator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!Regex.IsMatch(firtsPassword, regexPattern))
            {
                MessageBox.Show("The Password is not correct", "Validator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;            
            }
            MessageBox.Show("Password is validated", "Validator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
