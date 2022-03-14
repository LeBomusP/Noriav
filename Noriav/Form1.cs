using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noriav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password or username");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
        // TODO: mySQL connection and 

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("At current moment i dont have automatic password reset system. If you want to reset your password fell free to text to me on discord: BombP#1929 :)");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("At current moment password menager is in closed alpha that means at that moment there is no option to create personal account. If you want to test my app anyway you can log in on guest login but it does not have a lot of features that will be possible on personal account. Login: Guest   Password: 1324");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
