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
    public partial class Form2 : Form
    {
        String query;
        func func = new func();
        public Form2()
        {
            InitializeComponent();
            tbPass.UseSystemPasswordChar = true;
            tbRePass.UseSystemPasswordChar = true;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void bSignIn2_Click(object sender, EventArgs e)
        {
            String query2 = "select * from usersDb";
            if (tbLogin.Text != "" && tbPass.Text != "" && tbRePass.Text != "")
            {
                String login = tbLogin.Text;
                String password = tbPass.Text;
                String message = "Вы успешно зарегистрировались!";
                if (tbPass.Text == tbRePass.Text)
                {
                    if(func.getUserInfo(query2, 1,2).Item1 == login)
                    {
                        MessageBox.Show("Пользователь с данным логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        query = "insert into usersDb(usLogin, usPassword) values ('" + login + "', '" + password + "')";
                        func.setData(query, message);
                        MainForm mf = new MainForm();
                        this.Hide();
                        mf.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                
                MessageBox.Show("Не все поля заполнены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ToggleSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                tbPass.UseSystemPasswordChar = false;
                tbRePass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
                tbRePass.UseSystemPasswordChar = true;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
