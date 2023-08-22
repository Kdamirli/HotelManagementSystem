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
    public partial class UCCheckOut : UserControl
    {
        func func = new func();
        String query;
        int index;
        string[] mas;
        public UCCheckOut()
        {
            InitializeComponent();
        }

        private void UCCheckOut_Load(object sender, EventArgs e)
        {
            query = "select customer.custId, customer.custName, customer.custMobile, customer.custNation, customer.custGender, customer.custBirthday, customer.custProofId, customer.custAddress, customer.custCheckIn, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomId = rooms.roomid where checkOut = 'NO'";
            DataSet ds = func.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.custId, customer.custName, customer.custMobile, customer.custNation, customer.custGender, customer.custBirthday, customer.custProofId, customer.custAddress, customer.custCheckIn, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomId = rooms.roomid where custName like '"+ guna2TextBox1.Text+ "%' and checkOut = 'NO'";
            DataSet ds = func.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id = 0;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                index = e.RowIndex;
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                tbCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbRoomNumber.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                mas = new string[] { guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(), guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString(), guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString(), guna2DataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString() };
            }
        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if(tbCName.Text != "")
            {
                if(MessageBox.Show("Вы уверены?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    String cdate = dtCheckOut.Text;
                    query = "update customer set checkOut = 'YES', custCheckOut = '" + cdate + "' where custId = " + id + " update rooms set booked = 'NO', getOut = 'YES' where roomNo = '" + tbRoomNumber.Text + "'";
                    func.setData(query, "Гость успешно выселен!");
                    UCCheckOut_Load(this, null);
                    clearAll();

                    
                    var dtstart = Convert.ToDateTime(mas[2]).ToShortDateString();
                    var dtend = Convert.ToDateTime(dtCheckOut.Text).ToShortTimeString();
                    var days = (Convert.ToDateTime(dtend) - Convert.ToDateTime(dtstart)).Days;
                    var fullPr = Convert.ToInt32(mas[4]) * days;
                    var word = new Wordhelp("Отчет.docx");
                    var items = new Dictionary<string, string>
                    {
                        {"{acnumber}", rnd.Next(1000, 30000).ToString()},
                        {"{nowDate}", DateTime.Now.ToString()},
                        {"{custname}", mas[0]},
                        {"{selfid}", mas[1]},
                        {"{dateIn}", mas[2]},
                        {"{dateOut}", cdate},
                        {"{roomNo}", mas[3]},
                        {"{dayCount}", days.ToString()},
                        {"{price}", mas[4].ToString()},
                        {"{fullPr}", fullPr.ToString()}
                    };

                    word.Process(items);
                    MessageBox.Show("Word file created");
                }
            }
            else
            {
                MessageBox.Show("Гость не выбран", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearAll()
        {
            tbCName.Clear();
            guna2TextBox1.Clear();
            tbRoomNumber.Clear();
            dtCheckOut.ResetText();
        }

        private void UCCheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}