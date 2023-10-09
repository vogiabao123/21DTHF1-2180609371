using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTSV
{
    public partial class QLTTSV : Form
    {
        public QLTTSV()
        {
            InitializeComponent();
            comboBoxEdit1.SelectedIndex = 0;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(textBox1.Text);
                if(selectedRow == -1)
                {
                    throw new Exception("khong tim duoc mssv can xoa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("ban co muon xoa?", "yes/No", MessageBoxButtons.YesNo);
                    if(dr== DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("xoa sinnh vien thanh cong","thong bao",MessageBoxButtons.OK);
                    }
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"loi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    throw new Exception("Vui long nhap day du thong tin sinh vien!");
                int selectedRow = GetSelectedRow(textBox1.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dataGridView1.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Them moi du lieu thanh cong!", "Thong bao", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cap nhat du lieu thanh cong!", "Thong bao", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            // Hiển thị hộp thoại thông báo và kiểm tra kết quả người dùng
            DialogResult result = MessageBox.Show("Bạn có muốn thoat?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả người dùng
            // MessageBox.Show trả về một DialogResult để kiểm tra kết quả người dùng  sau khi họ đóng hộp thoại.

            if (result == DialogResult.Yes)
            {
                Console.WriteLine("Người dùng đã chọn Yes.");
                Close();
            }
            else
            {
                Console.WriteLine("Người dùng đã chọn No hoặc đóng hộp thoại.");
            }
           

       
        }
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dataGridView1.Rows[selectedRow].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[selectedRow].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[selectedRow].Cells[2].Value = radioButton2.Checked ? "Nữ" : "Nam";
            dataGridView1.Rows[selectedRow].Cells[3].Value =
           float.Parse(textBox3.Text).ToString();
            dataGridView1.Rows[selectedRow].Cells[4].Value = comboBoxEdit1.Text;
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
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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
