using HotelReservation.Business.Services;
using HotelReservation.DataAccess;
using HotelReservation.DataAccess.Repositories;
using HotelReservation.Entity.Concrete;
using HotelReservation.UI.Forms.GuestForms;
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
    public partial class Frm_Booking : Form
    {
        private readonly BookingService _bookingService;
        private readonly GuestService _guestService;
        private readonly RoomService _roomService;
        private readonly RoomTypeService _roomTypeService;
        private readonly HotelService _hotelService;
        private readonly BookingGuestsService _bookingGuestsService;
        private readonly PaymentService _paymentService;

        private Booking _currentBooking;

        private int _countGuest;

        private Decimal _selectedRoomTypePrice;

        public Frm_Booking()
        {
            InitializeComponent();

            var dbContext = new ApplicationDBContext();

            var bookingRepo = new BookingRepository(dbContext);
            _bookingService = new BookingService(bookingRepo);

            var guestRepo = new GuestRepository(dbContext);
            _guestService = new GuestService(guestRepo);

            var roomRepo = new RoomRepository(dbContext);
            _roomService = new RoomService(roomRepo);

            var roomTypeRepo = new RoomTypeRepository(dbContext);
            _roomTypeService = new RoomTypeService(roomTypeRepo);

            var hotelRepo = new HotelRepository(dbContext);
            _hotelService = new HotelService(hotelRepo);

            var bookingGuestRepo = new BookingGuestsRepository(dbContext);
            _bookingGuestsService = new BookingGuestsService(bookingGuestRepo);

            var paymentRepo = new PaymentRepository(dbContext);
            _paymentService = new PaymentService(paymentRepo);
        }


        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                //Değerleri al
                DateTime CheckIn = dtpCheckIn.Value;
                DateTime CheckOut = dtpCheckOut.Value;
                Room room = cmbRoom.SelectedItem as Room;

                //Gün sayısı
                int TotalDays = (CheckOut - CheckIn).Days;

                //Gecelik fiyat
                Decimal PricePerNight = _selectedRoomTypePrice;

                //Toplam fiyat
                Decimal TotalPrice = PricePerNight * TotalDays;

                //Booking nesnesi oluştur
                _currentBooking = new Booking
                {
                    CheckInDate = CheckIn,
                    CheckOutDate = CheckOut,
                    TotalPrice = TotalPrice,
                    Room = room
                };

                //Booking nesnesini geçici olarak sakla
                _bookingService.Insert(_currentBooking);

                //Nud'deki kadar yeni Guest ve BookingGuest oluştur
                _countGuest = (int)nudGuest.Value;
                CreateGuestInputFileds(_countGuest);
                CreateBookingGuests(_countGuest);


                for (int i = 0; i < _countGuest; i++)
                {
                    var booking = new Booking()
                    {
                        CheckInDate = CheckIn,
                        CheckOutDate = CheckOut,
                        Room = room,
                        TotalPrice = TotalPrice
                    };
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void CreateBookingGuests(int guestCount)
        {
            throw new NotImplementedException();
        }

        //Misafir GroupBox'unu burda oluşturuyoruz.
        private void CreateGuestInputFileds(int guestCount)
        {
            grpGuestInput.Controls.Clear();

            //Labelları burada ekleyeceğiz. Bir kere eklenecek zaten
            var lblFirstName = new Label { Text = "Ad", Top = 70, Left = 6 };
            var lblLastName = new Label { Text = "Soyad", Top = 70, Left = 136 };
            var lblBirthDate = new Label { Text = "Doğum Tarihi", Top = 70, Left = 266 };
            var lblAddress = new Label { Text = "Adres", Top = 70, Left = 396 };
            var lblPhone = new Label { Text = "Telefon", Top = 70, Left = 526 };
            var lblEmail = new Label { Text = "E-Posta", Top = 70, Left = 656 };

            //Müşteri sayısı kadar textboxu burada ekleyeceğiz.

            for (int i = 0; i < guestCount; i++)
            {

                var firstNameTextBox = new TextBox { Name = $"txtFirstName{i + 1}", Top = i * 33 + 93, Left = 6 };
                var lastNameTextBox = new TextBox { Name = $"txtLastName{i + 1}", Top = i * 33 + 93, Left = 136 };
                var birthDateDtp = new TextBox { Name = $"dtpBirthDate{i + 1}", Top = i * 33 + 93, Left = 266 };
                var AddressTextBox = new TextBox { Name = $"txtAddress{i + 1}", Top = i * 33 + 93, Left = 396 };
                var PhoneTextBox = new TextBox { Name = $"txtPhone{i + 1}", Top = i * 33 + 93, Left = 526 };
                var EmailTextBox = new TextBox { Name = $"txtEmail{i + 1}", Top = i * 33 + 93, Left = 656 };

                grpGuestInput.Controls.Add(firstNameTextBox);
                grpGuestInput.Controls.Add(lastNameTextBox);
                grpGuestInput.Controls.Add(birthDateDtp);
                grpGuestInput.Controls.Add(AddressTextBox);
                grpGuestInput.Controls.Add(PhoneTextBox);
                grpGuestInput.Controls.Add(EmailTextBox);
            }

            grpGuestInput.Controls.Add(lblFirstName);
            grpGuestInput.Controls.Add(lblLastName);
            grpGuestInput.Controls.Add(lblBirthDate);
            grpGuestInput.Controls.Add(lblAddress);
            grpGuestInput.Controls.Add(lblPhone);
            grpGuestInput.Controls.Add(lblEmail);

        }

        private void Frm_Booking_Load(object sender, EventArgs e)
        {
            GetAllHotels();
            GetAllRoomTypes();
            GetAllRooms();
        }

        private void GetAllRooms()
        {
            //var rooms = _roomService.GetRoomsByHotelId(hotelId).Select(r => new { r.RoomNumber, r.Id }).ToList();

            cmbRoom.DataSource = _roomService.GetAll().ToList();
            cmbRoom.DisplayMember = "RoomNumber";
            cmbRoom.ValueMember = "Id";


        }

        private void GetAllRoomTypes()
        {
            cmbRoomType.DataSource = _roomTypeService.GetAll();
            cmbRoomType.DisplayMember = "TypeName";
            cmbRoomType.ValueMember = "Id";
        }

        private void GetAllHotels()
        {
            cmbHotel.DataSource = _hotelService.GetAll().ToList();
            cmbHotel.DisplayMember = "HotelName";
            cmbHotel.ValueMember = "Id";
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHotel.SelectedIndex != -1)
            {

                GetAllRooms();
            }

        }

        Decimal Price;

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomType.SelectedItem is RoomType selectedRoomType)
            {
                _selectedRoomTypePrice = selectedRoomType.PricePerNight;
            }
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Değerleri ayrı ayrı yerlerden alacağız bu sefer

                Decimal amount = _currentBooking.TotalPrice * _countGuest;

                DateTime paymentDate = DateTime.Now;
                if (cmbPaymentDate.SelectedIndex == 0)
                {
                    paymentDate = _currentBooking.CheckInDate;
                }

                string paymentMethod = cmbPaymentMethod.Text;

                //Payment nesnesini oluştur
                Payment payment = new Payment
                {
                    Amount = amount,
                    PaymentMethod = paymentMethod,
                    PaymentDate = paymentDate,
                    BookingId = _currentBooking.Id,
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveGuests_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _countGuest; i++)
            {
                //Her bir Guest için gelen bilgileri al

                string firstName = grpGuestInput.Controls[$"txtFirstName{i + 1}"].Text;
                string lastName = grpGuestInput.Controls[$"txtLastName{i + 1}"].Text;
                var birthDate = ((DateTimePicker)grpGuestInput.Controls[$"dtpBirthDate{i + 1}"]).Value;
                string address = grpGuestInput.Controls[$"txtAddress{i + 1}"].Text;
                string phone = grpGuestInput.Controls[$"txtPhone{i + 1}"].Text;
                string email = grpGuestInput.Controls[$"txtEmail{i + 1}"].Text;

                //Her bir Guest için yeni Guest aç

                Guest guest = new Guest()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = DateOnly.FromDateTime(birthDate),
                    Address = address,
                    Phone = phone,
                    Email = email
                };

                //Her bir Guest'i veritabanına kaydet

                _guestService.Insert(guest);

                //BookingGuests ilişki tablosuna kayıt ekle

                BookingGuests bookingGuest = new BookingGuests()
                {
                    BookingId = _currentBooking.Id,
                    GuestId = guest.Id
                };

                _bookingGuestsService.Insert(bookingGuest);
            }

        }
    }
}
