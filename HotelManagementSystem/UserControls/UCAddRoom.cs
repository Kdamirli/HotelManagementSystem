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
    public partial class UCAddRoom : UserControl
    {
        func func = new func();
        String query;
        public UCAddRoom()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            tbRoomNo.Clear();
            cbRoomType.SelectedIndex = -1;
            cbBed.SelectedIndex = -1;
            tbPrice.Clear();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbRoomNo.Text != "" && cbBed.Text != "" && cbRoomType.Text != "" && tbPrice.Text != "")
            {
                String message = "Комната добавлена!";
                String roomNo = tbRoomNo.Text;
                String roomType = cbRoomType.Text;
                String bed = cbBed.Text;
                Int64 price = int.Parse(tbPrice.Text);
                query = "insert into rooms(roomNo, roomType, bed, price) values ('" + roomNo + "', '" + roomType + "', '" + bed + "', " + price + ")";
                func.setData(query, message);
                UCAddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void UCAddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = func.getData(query);   
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void UCAddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UCAddRoom_Enter(object sender, EventArgs e)
        {
            UCAddRoom_Load(this, null);
        }
    }
}
