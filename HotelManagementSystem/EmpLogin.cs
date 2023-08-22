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
    public partial class EmpLogin : Form
    {
        String query;
        func fn = new func();
        public EmpLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != "" && txtLogin.Text != "")
            {
                query = "select * from employee";
                string log = fn.getUserInfo(query, 5, 6).Item1;
                string pass = fn.getUserInfo(query, 5, 6).Item2;
                if (log == txtLogin.Text && pass == txtPass.Text)
                {
                    EmpForm empForm = new EmpForm();
                    empForm.Show();
                    this.Hide();
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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
