using HotelReservation.Business.Services;
using HotelReservation.DataAccess;
using HotelReservation.DataAccess.Repositories;
using HotelReservation.Entity.Concrete;
using HotelReservation.UI.Forms.GuestForms;
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
                int TotalDays = (CheckOut-CheckIn).Days;

                //Gecelik fiyat
                Decimal PricePerNight = _selectedRoomTypePrice;

                //Toplam fiyat
                Decimal TotalPrice = PricePerNight * TotalDays;

                //Nud'deki kadar yeni rezervasyon oluştur
                int guestCount = (int)nudGuest.Value;

                for (int i = 0; i < guestCount; i++) 
                {
                    var booking = new Booking()
                    {
                        CheckInDate = CheckIn,
                        CheckOutDate = CheckOut,
                        Room = room,
                        TotalPrice = TotalPrice
                    };
                }
                    

                switch (guestCount)
                {
                    case 1:
                        
                        Frm_OneGuest frm_OneGuest = new Frm_OneGuest();
                        frm_OneGuest.Show();
                        break;

                    case 2:
                        Frm_TwoGuest frm_TwoGuest = new Frm_TwoGuest();
                        frm_TwoGuest.Show();
                        break;

                    case 3:
                        Frm_ThreeGuest frm_ThreeGuest = new Frm_ThreeGuest();
                        frm_ThreeGuest.Show();
                        break;

                    case 4:
                        Frm_FourGuest frm_FourGuest = new Frm_FourGuest();
                        frm_FourGuest.Show();
                        break;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



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
    }
}
