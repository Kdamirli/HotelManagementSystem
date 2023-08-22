using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.UserControls
{
    public partial class UCEmployee : UserControl
    {
        func fn = new func();
        String query;
        public UCEmployee()
        {
            InitializeComponent();
            tbPass.UseSystemPasswordChar = true;
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

        private void UCEmployee_Load(object sender, EventArgs e)
        {
            getId();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "" && tbPhoneNo.Text != "" && cbGender.Text != "" && tbEmail.Text != "" && tbLogin.Text != "" && tbPass.Text != "")
            {
                String name = tbName.Text;
                String phone = tbPhoneNo.Text;
                String gender = cbGender.Text;
                String email = tbEmail.Text;
                String login = tbLogin.Text;
                String password = tbPass.Text;

                query = "insert into employee(eName, ePhoneNo, eGender, eEmailId, userName, pass) values('"+name+"', '"+phone+"', '"+gender+"', '"+email+"', '"+login+"', '"+password+"')";
                fn.setData(query, "Работник зарегистрирован!");
                getId();
                clearAll();
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void empTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empTabControl.SelectedIndex == 1)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (empTabControl.SelectedIndex == 2)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query);
                guna2DataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                if(MessageBox.Show("Вы уверены?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eId = " + txtId.Text + "";
                    fn.setData(query, "Работник удален");
                    empTabControl_SelectedIndexChanged(this, null);
                }
            }
            else
            {
                MessageBox.Show("Введите id работника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCEmployee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        /// <summary>
        /// Methods
        /// </summary>
        private void getId()
        {
            query = "select max(eId) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                int num = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelID.Text = (num + 1).ToString();
            }
        }

        private void clearAll()
        {
            tbName.Clear();
            tbPhoneNo.Clear();
            cbGender.SelectedIndex = -1;
            tbEmail.Clear();
            tbLogin.Clear();
            tbPass.Clear();
            txtId.Clear();
        }
    }
}