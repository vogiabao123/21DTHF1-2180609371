using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public partial class txtN1 : Form
    {
       

        public txtN1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(textBox1.Text);
                float number2 = float.Parse(textBox2.Text);
                float result = number1 + number2;
                txtdapan.Text = result.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(textBox1.Text);
                float number2 = float.Parse(textBox2.Text);
                float result = number1 - number2;
                txtdapan.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(textBox1.Text);
                float number2 = float.Parse(textBox2.Text);
                float result = number1 * number2;
                txtdapan.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            float number1 = float.Parse(textBox1.Text);
            float number2 = float.Parse(textBox2.Text);
            float result = number1 / number2;
            txtdapan.Text = result.ToString();

            try
            {
                if (number2 == 0)
                    MessageBox.Show("so bi chia khac 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
