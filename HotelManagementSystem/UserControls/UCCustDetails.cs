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
    public partial class UCCustDetails : UserControl
    {
        func func = new func();
        String query;
        public UCCustDetails()
        {
            InitializeComponent();
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSearchBy.SelectedIndex == 0)
            {
                query = "select customer.custId, customer.custName, customer.custMobile, customer.custNation, customer.custGender, customer.custBirthday, customer.custProofId, customer.custAddress, customer.custCheckIn, customer.custCheckOut, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomId = rooms.roomid";
                getRecord(query);
            }
            else
            {
                if (cbSearchBy.SelectedIndex == 1)
                {
                    query = "select customer.custId, customer.custName, customer.custMobile, customer.custNation, customer.custGender, customer.custBirthday, customer.custProofId, customer.custAddress, customer.custCheckIn, customer.custCheckOut, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomId = rooms.roomid where custCheckOut is null";
                    getRecord(query);
                }
                else
                {
                    if (cbSearchBy.SelectedIndex == 2)
                    {
                        query = "select customer.custId, customer.custName, customer.custMobile, customer.custNation, customer.custGender, customer.custBirthday, customer.custProofId, customer.custAddress, customer.custCheckIn, customer.custCheckOut, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomId = rooms.roomid where custCheckOut is not null";
                        getRecord(query);
                    }
                }
            }
        }

        private void getRecord(String query1)
        {
            DataSet ds = func.getData(query1);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void UCCustDetails_Leave(object sender, EventArgs e)
        {
            cbSearchBy.SelectedIndex = -1;
        }
    }
}
