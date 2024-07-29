﻿using System;
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
    public partial class ToBeDeleted : Form
    {
        private int _count;
        public ToBeDeleted()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _count = (int)nudCount.Value;
            CreateGuestInputFileds(_count);
        }

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

    }
}
