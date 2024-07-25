using HotelReservation.Business.Abstract;
using HotelReservation.Business.Services;
using HotelReservation.DataAccess.Repositories;
using HotelReservation.DataAccess;
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
    public partial class Frm_RoomType : Form
    {
        private readonly RoomTypeService _roomTypeService;
        public Frm_RoomType()
        {
            InitializeComponent();

            //Dependency Injection ile CategoryService oluştur
            var dbContext = new ApplicationDBContext();
            var roomTypeRepo = new RoomTypeRepository(dbContext);
            _roomTypeService = new RoomTypeService(roomTypeRepo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Formdan verileri al
                string type = txtTypeName.Text;
                string desc = txtDescription.Text;
                int capacity = (int)nudCapacity.Value;
                decimal price = decimal.Parse(txtPrice.Text);

                //Yeni bir oda tipi oluştur
                RoomType newRoomType = new RoomType()
                {
                    TypeName = type,
                    Description = desc,
                    PricePerNight = price,
                    Capacity = capacity
                };

                //Kaydet
                _roomTypeService.Insert(newRoomType);
                MessageBox.Show("Kayıt Başarılı");
                ListAllRoomTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
        }

        private void ListAllRoomTypes()
        {
            lstRoomType.DataSource = null;
            lstRoomType.Items.Clear();
            lstRoomType.ValueMember = "Id";
            lstRoomType.DisplayMember = "TypeName";
            lstRoomType.DataSource = _roomTypeService.GetAll();

        }

        private void Frm_RoomType_Load(object sender, EventArgs e)
        {
            ListAllRoomTypes();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstRoomType.SelectedIndex != -1)
                {
                    RoomType secilen = (RoomType)lstRoomType.SelectedItem;
                    _roomTypeService.Remove(secilen);
                    ListAllRoomTypes();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        RoomType secilen;
        private void lstRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRoomType.SelectedIndex != -1)
            {
                secilen = (RoomType)lstRoomType.SelectedItem;
                txtTypeName.Text = secilen.TypeName;
                txtDescription.Text = secilen.Description;
                txtPrice.Text = secilen.PricePerNight.ToString();
                nudCapacity.Value = secilen.Capacity;

            }
        }
    }
}
