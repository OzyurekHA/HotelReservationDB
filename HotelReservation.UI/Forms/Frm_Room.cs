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
    public partial class Frm_Room : Form
    {

        private readonly RoomService _roomService;
        private readonly HotelService _hotelService;
        private readonly RoomTypeService _roomTypeService;

        public Frm_Room()
        {
            InitializeComponent();

            var dbContext = new ApplicationDBContext();

            var roomRepo = new RoomRepository(dbContext);
            _roomService = new RoomService(roomRepo);

            var hotelRepo = new HotelRepository(dbContext);
            _hotelService = new HotelService(hotelRepo);

            var roomTypeRepo = new RoomTypeRepository(dbContext);
            _roomTypeService = new RoomTypeService(roomTypeRepo);
        }

        private void Frm_Room_Load(object sender, EventArgs e)
        {
            GetAllHotels();
            GetAllRoomTypes();
        }

        private void GetAllRoomTypes()
        {
            var roomTypes = _roomTypeService.GetAll();
            cmbRoomType.DataSource = roomTypes.ToList();
            cmbRoomType.DisplayMember = "TypeName";
            cmbHotel.ValueMember = "Id";
        }

        private void GetAllHotels()
        {
            var hotels = _hotelService.GetAll();
            cmbHotel.DataSource = hotels.ToList(); //Bu ToList olayından emin değilim
            cmbHotel.DisplayMember = "HotelName";
            cmbHotel.ValueMember = "Id";
        }

        bool isReserved;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //Formdan veriyi al
                Hotel hotel = (Hotel)cmbHotel.SelectedItem;
                RoomType roomType = (RoomType)cmbRoomType.SelectedItem;

                if (cmbIsReserved.SelectedIndex == 0)
                {
                    isReserved = true;
                }
                isReserved = false;

                //Yeni oda oluştur
                Room room = new Room()
                {
                    Hotel = hotel,
                    RoomType = roomType,
                    IsReserved = isReserved
                };

                //Kaydet
                _roomService.Insert(room);
                MessageBox.Show("Kayıt Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
