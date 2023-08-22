using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        String query;
        func func = new func();
        public Form1()
        {
            InitializeComponent();
            tbPass.UseSystemPasswordChar = true;
            label2.Visible = false;
            tbLogin.Text = "Azorty";
            tbPass.Text = "123";
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                tbPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
        private void bSignIn_Click(object sender, EventArgs e)
        {
            if (tbPass.Text != "" && tbLogin.Text != "")
            {
                query = "select * from usersDb";
                string log = func.getUserInfo(query,1,2).Item1;
                string pass = func.getUserInfo(query, 1, 2).Item2;
                if (log == tbLogin.Text && pass == tbPass.Text)
                {
                    MainForm mf = new MainForm();
                    this.Hide();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Пользователя не существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            EmpLogin emp = new EmpLogin();
            emp.Show();
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}