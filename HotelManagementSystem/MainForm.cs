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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = false;
            btn_show.Visible = true;
            btn_hide.Visible = false;
            guna2Panel1.Visible = false;
            guna2Panel1.Width = 55;
            ucAddRoom1.Location = new System.Drawing.Point(80, 47);
            ucAddRoom1.Size = new System.Drawing.Size(1194, 567);
            ucCustomerRegistration1.Location = new System.Drawing.Point(80, 47);
            ucCustomerRegistration1.Size = new System.Drawing.Size(1198, 567);
            ucCheckOut1.Location = new System.Drawing.Point(80, 47);
            ucCheckOut1.Size = new System.Drawing.Size(1198, 567);
            ucCustDetails1.Location = new System.Drawing.Point(80, 47);
            ucCustDetails1.Size = new System.Drawing.Size(1198, 567);
            ucEmployee1.Location = new System.Drawing.Point(80, 47);
            ucEmployee1.Size = new System.Drawing.Size(1198, 567);
            guna2Transition1.ShowSync(guna2Panel1);
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = true;
            btn_show.Visible = false;
            btn_hide.Visible = true;
            guna2Panel1.Visible = false;
            guna2Panel1.Width = 237;
            ucAddRoom1.Location = new System.Drawing.Point(246, 47);
            ucAddRoom1.Size = new System.Drawing.Size(1032, 567);
            ucCustomerRegistration1.Location = new System.Drawing.Point(246, 47);
            ucCustomerRegistration1.Size = new System.Drawing.Size(1032, 567);
            ucCheckOut1.Location = new System.Drawing.Point(246, 47);
            ucCheckOut1.Size = new System.Drawing.Size(1032, 567);
            ucCustDetails1.Location = new System.Drawing.Point(246, 47);
            ucCustDetails1.Size = new System.Drawing.Size(1032, 567);
            ucEmployee1.Location = new System.Drawing.Point(246, 47);
            ucEmployee1.Size = new System.Drawing.Size(1032, 567);
            guna2Transition1.ShowSync(guna2Panel1);
        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            ucAddRoom1.Visible = true;
            ucAddRoom1.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btn_show.Visible = false;
            ucAddRoom1.Visible = false;
            ucCustomerRegistration1.Visible = false;
            ucCheckOut1.Visible = false;
            ucCustDetails1.Visible = false;
            ucEmployee1.Visible = false;
        }

        private void btn_CustReg_Click(object sender, EventArgs e)
        {
            ucCustomerRegistration1.Visible = true;
            ucCustomerRegistration1.BringToFront();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            ucCheckOut1.Visible = true;
            ucCheckOut1.BringToFront();
        }

        private void btn_CustInfo_Click(object sender, EventArgs e)
        {
            ucCustDetails1.Visible = true;
            ucCustDetails1.BringToFront();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            ucEmployee1.Visible = true;
            ucEmployee1.BringToFront();
        }
    }
}
