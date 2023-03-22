using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
         private void Form1_Load(object sender, EventArgs e)
        {
            OthersLbl.Visible = false;
            OthersTextBox.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string str = " ";
            if (checkBox1.Checked == true)
            {
                str = str + checkBox1.Text;
                str += " ";
            }

            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text;
                str += " ";
            }

            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text;
                str += " ";
            }

            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text;
                str += " ";
            }

            if (othersCheckBox.Checked == true)
            {
                str = str + OthersTextBox.Text;
                str += " ";
            }


            if (str != null)
            {
                MessageBox.Show("You selected: \n" + str + "\nThank you!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void othersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (othersCheckBox.Checked == false)
            {
                OthersLbl.Visible = false;
                OthersTextBox.Visible = false;
            }
            else
            {
                OthersLbl.Visible = true;
                OthersTextBox.Visible = true;

            }
    }
}
