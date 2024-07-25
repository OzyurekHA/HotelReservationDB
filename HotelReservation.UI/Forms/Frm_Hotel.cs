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
    public partial class Frm_Hotel : Form
    {
        private readonly HotelService _hotelService;
        public Frm_Hotel()
        {
            InitializeComponent();

            var dbContext = new ApplicationDBContext();
            var hotelRepo = new HotelRepository(dbContext);
            _hotelService = new HotelService(hotelRepo);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //Formdan değerleri al
                string name = txtName.Text;
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;
                int star = (int)nudStars.Value;

                //Yeni bir hotel oluştur
                Hotel newHotel = new Hotel()
                {
                    HotelName = name,
                    Address = address,
                    Phone = phone,
                    Email = email,
                    Stars = star,
                };

                //Aynı hotel'den var mı kontrol et
                if (_hotelService.IfEntityExists(newHotel.HotelName))
                {
                    throw new Exception("Bu otel zaten kayıtlı");
                }

                //Yoksa kaydet
                _hotelService.Insert(newHotel);
                MessageBox.Show("Kayıt Başarılı");
                GetAllHotels();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GetAllHotels()
        {
            lstHotels.DataSource = null;
            lstHotels.Items.Clear();
            lstHotels.ValueMember = "Id";
            lstHotels.DisplayMember = "HotelName";
            lstHotels.DataSource = _hotelService.GetAll();
        }

        private void Frm_Hotel_Load(object sender, EventArgs e)
        {
            GetAllHotels();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstHotels.SelectedIndex != -1)
                {
                    Hotel secilen = (Hotel)lstHotels.SelectedItem;
                    _hotelService.Remove(secilen);
                    GetAllHotels();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        Hotel secilen;
        private void lstHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHotels.SelectedIndex != -1)
            {
                secilen = (Hotel)lstHotels.SelectedItem;
                txtName.Text = secilen.HotelName;
                txtAddress.Text = secilen.Address;
                txtEmail.Text = secilen.Email;
                txtPhone.Text = secilen.Phone;
                nudStars.Value = secilen.Stars;
            }
        }
    }
}
