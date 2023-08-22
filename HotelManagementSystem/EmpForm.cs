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
    public partial class EmpForm : Form
    {
        String query;
        func fn = new func();
        public EmpForm()
        {
            InitializeComponent();
        }

        private void EmpForm_Load(object sender, EventArgs e)
        {
            query = "select rooms.roomid, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price, rooms.getOut from rooms where rooms.getOut = 'YES'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            timer1.Enabled = true;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            query = "update rooms set getOut = 'YES' where booked = 'YES'";
            fn.setData(query, "dldl");
            EmpForm_Load(this, null);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text != "")
            {
                query = "update rooms set getOut = 'NO' where roomNo = '"+guna2TextBox1.Text+"'";
                fn.setData(query, "Номер убран");
                EmpForm_Load(this, null);
                guna2TextBox1.Clear();
            }
            else
            {
                MessageBox.Show("Номер не выбран", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                guna2TextBox1.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
