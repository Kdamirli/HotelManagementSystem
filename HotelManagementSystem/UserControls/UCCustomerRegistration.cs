using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace HotelManagementSystem.UserControls
{
    public partial class UCCustomerRegistration : UserControl
    {
        func func = new func();
        String query;
        public UCCustomerRegistration()
        {
            InitializeComponent();
        }
        public void clearAll()
        {
            tbName.Clear();
            tbPhoneNumber.Clear();
            tbNation.Clear();
            cbGender.SelectedIndex = -1;
            dtBirthday.ResetText();
            tbId.Clear();
            tbAddress.Clear();
            dtCheckIn.ResetText();
            cbBed.SelectedIndex = -1;
            cbRoomNumber.Items.Clear();
            cbRoomType.SelectedIndex = -1;
            tbPrice.Clear();
        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = func.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbPhoneNumber.Text != "" && tbNation.Text != "" && cbGender.Text != "" && dtBirthday.Text != "" && tbId.Text != "" && tbAddress.Text != "" && dtCheckIn.Text != "" && tbPrice.Text != "")
            {
                String name = tbName.Text;
                Int64 mobile = Convert.ToInt64(tbPhoneNumber.Text);
                String national = tbNation.Text;
                String gender = cbGender.Text;
                String dob = dtBirthday.Text;
                String id = tbId.Text;
                String address = tbAddress.Text;
                String checkIn = dtCheckIn.Text;

                query = "insert into customer(custName, custMobile, custNation, custGender, custBirthday, custProofId, custAddress, custCheckIn, roomId) values('" + name + "', " + mobile + ", '" + national + "', '" + gender + "', '" + dob + "', '" + id + "', '" + address + "', '" + checkIn + "', " + rumid + ") update rooms set booked = 'YES' where roomNo = '"+cbRoomNumber.Text+"'";
                func.setData(query, "Номер " + cbRoomNumber.Text + " выдан успешно!");
                clearAll();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoomNumber.Items.Clear();
            tbPrice.Clear();
            query = "select roomNo from rooms where bed = '" + cbBed.Text + "' and roomType='" + cbRoomType.Text + "' and booked = 'NO'";
            setComboBox(query, cbRoomNumber);
        }

        private void cbBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoomType.SelectedIndex = -1;
            cbRoomNumber.Items.Clear();
            tbPrice.Clear();
        }

        int rumid;

        private void cbRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price, roomid from rooms where roomNo = '" + cbRoomNumber.Text + "'";
            DataSet ds = func.getData(query);
            tbPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rumid = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
        }

        private void UCCustomerRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
