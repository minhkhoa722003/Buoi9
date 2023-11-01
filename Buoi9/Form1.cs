using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Buoi9
{
    public partial class Form1 : Form
    {
        KetNoi kn = new KetNoi();
        SqlConnection connsql;

        public Form1()
        {
            InitializeComponent();
            connsql = kn.connect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string insertString;
                insertString = "insert into Khoa values('" + textBox1.Text + "',N'" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                if(connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Thanh cong");

            }
            catch(Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string updateString = "update Khoa set TenKhoa='" + textBox2.Text + "' where MaKhoa='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(updateString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Thanh cong");

            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string deleteString = "delete Khoa where MaKhoa='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Thanh cong");

            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }


    }
}
