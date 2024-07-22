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
    public partial class Frm_Guest : Form
    {
        public Frm_Guest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                
                string guestName = txtName.Text;
                string guestSurname = txtSurname.Text;
                string guestAddress = txtAddress.Text;
                //DateOnly birthDate = dtpBirthDate.Value;
                string guestPhone = txtPhone.Text;
                string guestEmail = txtEmail.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
