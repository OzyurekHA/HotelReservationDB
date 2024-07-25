using HotelReservation.Business.Services;
using HotelReservation.DataAccess;
using HotelReservation.DataAccess.Repositories;
using HotelReservation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
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
    public partial class Frm_Staff : Form
    {
        private readonly StaffService _staffService;
        private readonly HotelService _hotelService;
        public Frm_Staff()
        {
            InitializeComponent();

            var dbContext = new ApplicationDBContext();
            var staffRepo = new StaffRepository(dbContext);
            _staffService = new StaffService(staffRepo);

            var hotelRepo = new HotelRepository(dbContext);
            _hotelService = new HotelService(hotelRepo);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Formdan bilgileri al
                string name = txtFirstName.Text;
                string surname = txtLastName.Text;
                string position = txtPosition.Text;
                string phone = txtPhone.Text;
                string mail = txtEmail.Text;
                decimal salary = decimal.Parse(txtSalary.Text);
                DateOnly birthDate = DateOnly.FromDateTime(dtpBirthDate.Value);
                DateOnly hireDate = DateOnly.FromDateTime(dtpHireDate.Value);
                Hotel hotel = (Hotel)cmbHotel.SelectedItem;

                //Yeni bir staff oluştur
                Staff newStaff = new Staff()
                {
                    FirstName = name,
                    LastName = surname,
                    Position = position,
                    Salary = salary,
                    DateOfBirth = birthDate,
                    StaffPhoneNumber = phone,
                    StaffEmail = mail,
                    HireDate = hireDate,
                    Hotel = hotel
                };

                //Kaydet
                _staffService.Insert(newStaff);
                MessageBox.Show("Kayıt Başarılı");
                ListAllStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListAllStaff()
        {
            lstEmployees.DataSource = null;
            lstEmployees.Items.Clear();
            lstEmployees.ValueMember = "Id";
            lstEmployees.DisplayMember = "FullName";
            lstEmployees.DataSource = _staffService.GetAll();
        }

        private void Frm_Staff_Load(object sender, EventArgs e)
        {
            GetAllHotels();
            ListAllStaff();
        }

        private void GetAllHotels()
        {
            var hotels = _hotelService.GetAll();
            cmbHotel.DataSource = hotels.ToList(); //Bu ToList olayından emin değilim
            cmbHotel.DisplayMember = "HotelName";
            cmbHotel.ValueMember = "Id";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstEmployees.SelectedIndex != -1)
                {
                    Staff secilen = (Staff)lstEmployees.SelectedItem;
                    _staffService.Remove(secilen);
                    ListAllStaff();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Staff secilen;
        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedIndex != -1)
            {
                secilen = (Staff)lstEmployees.SelectedItem;
                txtFirstName.Text = secilen.FirstName;
                txtLastName.Text = secilen.LastName;
                txtPhone.Text = secilen.StaffPhoneNumber;
                txtPosition.Text = secilen.Position;
                txtSalary.Text = secilen.Salary.ToString();
                txtEmail.Text = secilen.StaffEmail;
                dtpBirthDate.Value = secilen.DateOfBirth.ToDateTime(TimeOnly.MinValue);
                dtpHireDate.Value = secilen.HireDate.ToDateTime(TimeOnly.MinValue);
                cmbHotel.SelectedItem = secilen.Hotel;
            }
        }
    }
}
