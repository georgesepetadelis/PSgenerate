using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSgenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
        }


        private static Random random = new Random();
        private static string makeRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@!#$%&*(){}[]'";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
            int len = Convert.ToInt32(pass_len.Text);
            if (pass_len.TextLength == 0) MessageBox.Show("the values can't be empty!");
            else
            { 
                if (len != null)
                {
                    ran_pass.Text = makeRandomString(len);
                    System.Windows.Forms.Clipboard.SetText(ran_pass.Text);
                    MessageBox.Show("password copied to clipboard!");
                }
                else MessageBox.Show("the values can't be empty!");
            }
        }
    }
}
