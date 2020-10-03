using System;
using System.Windows.Forms;

namespace Symulator_Intel_8086
{
    public partial class Forms : Form
    {

        private string a;
        private string b;


        public Forms()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = textBox2.Text;

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = "";
            b = "";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                MessageBox.Show("Wybrałeś ten sam rejestr");
            }

            if (comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = a;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                textBox2.Text = a;
            }

            if (comboBox2.SelectedIndex == 2)
            {
                textBox3.Text = a;
            }

            if (comboBox2.SelectedIndex == 3)
            {
                textBox4.Text = a;
            }

            if (comboBox2.SelectedIndex == 4)
            {
                textBox5.Text = a;
            }

            if (comboBox2.SelectedIndex == 5)
            {
                textBox6.Text = a;
            }

            if (comboBox2.SelectedIndex == 6)
            {
                textBox7.Text = a;
            }

            if (comboBox2.SelectedIndex == 7)
            {
                textBox8.Text = a;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                a = textBox1.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                a = textBox2.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 2)
            {
                a = textBox3.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 3)
            {
                a = textBox4.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 4)
            {
                a = textBox5.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 5)
            {
                a = textBox6.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 6)
            {
                a = textBox7.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 7)
            {
                a = textBox8.Text.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                b = textBox1.Text.ToString();
            }

            if (comboBox2.SelectedIndex == 1)
            {
                b = textBox2.Text.ToString();
            }

            if (comboBox2.SelectedIndex == 2)
            {
                b = textBox3.Text.ToString();
            }

            if (comboBox2.SelectedIndex == 3)
            {
                b = textBox4.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 4)
            {
                b = textBox5.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 5)
            {
                b = textBox6.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 6)
            {
                b = textBox7.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 7)
            {
                b = textBox8.Text.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = a;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                textBox2.Text = a;
            }

            if (comboBox2.SelectedIndex == 2)
            {
                textBox3.Text = a;
            }

            if (comboBox2.SelectedIndex == 3)
            {
                textBox4.Text = a;
            }

            if (comboBox2.SelectedIndex == 4)
            {
                textBox5.Text = a;
            }

            if (comboBox2.SelectedIndex == 5)
            {
                textBox6.Text = a;
            }

            if (comboBox2.SelectedIndex == 6)
            {
                textBox7.Text = a;
            }

            if (comboBox2.SelectedIndex == 7)
            {
                textBox8.Text = a;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = b;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                textBox2.Text = b;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                textBox3.Text = b;
            }

            if (comboBox1.SelectedIndex == 3)
            {
                textBox4.Text = b;
            }

            if (comboBox1.SelectedIndex == 4)
            {
                textBox5.Text = b;
            }

            if (comboBox1.SelectedIndex == 5)
            {
                textBox6.Text = b;
            }

            if (comboBox1.SelectedIndex == 6)
            {
                textBox7.Text = b;
            }

            if (comboBox1.SelectedIndex == 7)
            {
                textBox8.Text = b;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
