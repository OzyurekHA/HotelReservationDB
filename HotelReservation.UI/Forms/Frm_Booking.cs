using HotelReservation.Business.Services;
using HotelReservation.DataAccess;
using HotelReservation.DataAccess.Repositories;
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

        }

        private void Frm_Booking_Load(object sender, EventArgs e)
        {
            GetAllHotels();
            GetAllRoomTypes();
            GetAllRooms((Guid)cmbHotel.SelectedItem);
        }

        private void GetAllRooms(Guid hotelId)
        {
            var rooms = _roomService.GetRoomsByHotelId(hotelId).Select(r => new { r.RoomNumber, r.Id }).ToList();

            cmbRoom.DataSource = rooms;
            cmbRoom.DisplayMember = "RoomNumber";
            cmbRoom.ValueMember = "Id";

            
        }

        private void GetAllRoomTypes()
        {
            _roomTypeService.GetAll();
        }

        private void GetAllHotels()
        {
            cmbHotel.DataSource = _hotelService.GetAll().ToList();
            cmbHotel.DisplayMember = "HotelName";
            cmbHotel.ValueMember = "Id";
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guid selectedHotelId = (Guid)cmbHotel.SelectedValue;
            GetAllRooms(selectedHotelId);
        }
    }
}
