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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            GetAllRooms();
        }

        private void GetAllRooms()
        {
            using (var context = new ApplicationDBContext())
            {
                var rooms = from room in context.Rooms
                            join hotel in context.Hotels on room.HotelId equals hotel.Id
                            join roomType in context.RoomTypes on room.RoomTypeId equals roomType.Id
                            select new
                            {
                                isReserved = room.IsReserved ? "Dolu" : "Boş",
                                RoomNumber = room.RoomNumber,
                                HotelName = hotel.HotelName,
                                RoomTypeName = roomType.TypeName
                            };

                var roomList = rooms.ToList();

                foreach (var room in roomList)
                {
                    lstRoom.Items.Add($"{room.isReserved} - {room.RoomNumber} - {room.HotelName} - {room.RoomTypeName}");
                }
            }
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

        int roomNumber;
        bool isReserved;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //Formdan veriyi al
                if (int.TryParse(txtRoomNumber.Text, out roomNumber))
                {
                    //parsing successful 
                }
                else
                {
                    throw new Exception("Sadece sayı girin");
                }
                Hotel hotel = (Hotel)cmbHotel.SelectedItem;
                RoomType roomType = (RoomType)cmbRoomType.SelectedItem;

                if (cmbIsReserved.SelectedIndex == 0)
                {
                    isReserved = true;
                }
                isReserved = false;

                //Aynısından yoksa
                if (_roomService.IfEntityExists(roomNumber)) 
                {
                    throw new Exception("Bu oda zaten kayıtlı");
                }

                //Yeni oda oluştur
                Room room = new Room()
                {
                    RoomNumber = roomNumber,
                    Hotel = hotel,
                    RoomType = roomType,
                    IsReserved = isReserved
                };

                //Kaydet
                _roomService.Insert(room);
                MessageBox.Show("Kayıt Başarılı");
                GetAllRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
