using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation.UI.Forms
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Hotel frm_Hotel = new Frm_Hotel();
            frm_Hotel.Show();
        }

        private void btnRoomType_Click(object sender, EventArgs e)
        {
            Frm_RoomType frm_RoomType = new Frm_RoomType();
            frm_RoomType.Show();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Frm_Guest frm_Guest = new Frm_Guest();
            frm_Guest.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Frm_Staff frm_Staff = new Frm_Staff();
            frm_Staff.Show();
        }
    }
}
