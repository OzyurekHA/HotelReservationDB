using HotelReservation.Business.Services;
using HotelReservation.DataAccess;
using HotelReservation.DataAccess.Repositories;
using HotelReservation.Entity.Concrete;
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
        private readonly GuestService _guestService;

        public Frm_Guest()
        {
            InitializeComponent();

            //Dependency Injection ile CategoryServide oluştur
            var dbContext = new ApplicationDBContext();
            var guestRepo = new GuestRepository(dbContext);
            _guestService = new GuestService(guestRepo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //Formdan değerleri al
                string guestName = txtName.Text;
                string guestSurname = txtSurname.Text;
                string guestAddress = txtAddress.Text;
                DateOnly birthDate = DateOnly.FromDateTime(dtpBirthDate.Value);
                string guestPhone = txtPhone.Text;
                string guestEmail = txtEmail.Text;

                //Yeni bir guest oluştur
                Guest newGuest = new Guest()
                {
                    FirstName = guestName,
                    LastName = guestSurname,
                    DateOfBirth = birthDate,
                    Address = guestAddress,
                    Phone = guestPhone,
                    Email = guestEmail
                };

                //Aynısından yoksa
                if (_guestService.IfEntityExists(newGuest.FirstName, newGuest.LastName))
                {
                    throw new Exception("Bu misafir zaten kayıtlı");
                }

                //Kaydet
                _guestService.Insert(newGuest);
                MessageBox.Show("Kayıt Başarılı");
                GetAllGuests();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GetAllGuests()
        {
            lstMisafir.DataSource = null;
            lstMisafir.Items.Clear();
            lstMisafir.ValueMember = "Id";
            lstMisafir.DisplayMember = "FullName";
            lstMisafir.DataSource = _guestService.GetAll();
        }

        private void Frm_Guest_Load(object sender, EventArgs e)
        {
            GetAllGuests();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstMisafir.SelectedIndex != -1)
                {
                    Guest secilen = (Guest)lstMisafir.SelectedItem;
                    _guestService.Remove(secilen);
                    GetAllGuests();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        Guest secilen;
        private void lstMisafir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMisafir.SelectedIndex != -1)
            {
                secilen = (Guest)lstMisafir.SelectedItem;
                txtName.Text = secilen.FirstName;
                txtSurname.Text = secilen.LastName;
                dtpBirthDate.Value = secilen.DateOfBirth.ToDateTime(TimeOnly.MinValue);
                txtAddress.Text = secilen.Address;
                txtPhone.Text = secilen.Phone;
                txtEmail.Text = secilen.Email;
            }
        }
    }
}
