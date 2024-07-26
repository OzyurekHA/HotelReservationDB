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
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Booking_Load(object sender, EventArgs e)
        {

        }
    }
}
