﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Peti_Projekt_2
{
    public partial class Form1 : Form
    {
        int guestID;
        public Form1()
        {
            InitializeComponent();
            DateTime dt = new DateTime();
            dt = DateTime.Today.Date;

            lblDate.Text = dt.ToString("yyyy/MM/dd");
            
            
        }

        private void btnEngForm_Click(object sender, EventArgs e) //Magyarról angolra
        {
            if (btnBill.Text == "Számla megtekintése")
            {
                btnBill.Text = "Check bill";
            }

            if (btnRoomService.Text == "Szobaszervíz")
            {
                btnRoomService.Text = "Room Service";
            }

            if (btnDrinks.Text == "Étel/Ital rendelés")
            {
                btnDrinks.UseMnemonic = false;
                btnDrinks.Text = "Food & Drinks";
            }

            if (btnActivities.Text == "Szabadidős tevékenységek")
            {
                btnActivities.Text = "Activities";
            }

            if (btnCalendar.Text == "Naptár")
            {
                btnCalendar.Text = "Calendar";
            }

            if (btnWeather.Text == "Időjárás")
            {
                btnWeather.Text = "Weather";
            }
            if (btnLogin.Text == "Bejelentkezés")
            {
                btnLogin.Text = "Login";
            }
            if (btnLogout.Text == "Kijelentkezés")
            {
                btnLogout.Text = "Logout";
            }
            if (btnExit.Text == "Kilépés")
            {
                btnExit.Text = "Exit";
            }
            if (label1.Text == "Bejelentkezve mint: ")
            {
                label1.Text = "Logged in as: ";
            }




        }

        private void btnHunForm_Click(object sender, EventArgs e) //Angolról magyarra
        {
            if (btnBill.Text == "Check bill")
            {
                btnBill.Text = "Számla megtekintése";
            }

            if (btnRoomService.Text == "Room Service")
            {
                btnRoomService.Text = "Szobaszervíz";
            }

            if (btnDrinks.Text == "Food & Drinks")
            {
                btnDrinks.UseMnemonic = false;
                btnDrinks.Text = "Étel/Ital rendelés";
            }

            if (btnActivities.Text == "Activities")
            {
                btnActivities.Text = "Szabadidős tevékenységek";
            }

            if (btnCalendar.Text == "Calendar")
            {
                btnCalendar.Text = "Naptár";
            }

            if (btnWeather.Text == "Weather")
            {
                btnWeather.Text = "Időjárás";
            }
            if (btnLogin.Text == "Login")
            {
                btnLogin.Text = "Bejelentkezés";
            }
            if (btnLogout.Text == "Logout")
            {
                btnLogout.Text = "Kijelentkezés";
            }
            if (btnExit.Text == "Exit")
            {
                btnExit.Text = "Kilépés";
            }
            if (label1.Text == "Logged in as: ")
            {
                label1.Text = "Bejelentkezve mint: ";
            }



        }

        private void btnDrinks_Click(object sender, EventArgs e) //Étel/Ital gomb következö formba lépése
        {
            if (guestID == 0)
            {
                System.Windows.Forms.MessageBox.Show("Kérlek jelentkezz be");
            }
            else
            {
                var drinksFood = new Form();
                drinksFood.Show();
            }

        }
        private void Form_Load(object sender, EventArgs e)
        {
            this.Text = "teszt";
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //            var form2 = new Form2();
            //            form2.Show();
            try
            {
                using (var form2 = new Form2())
                {
                    var result = form2.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        lblGuest.Text = form2.returnValue;
                        guestID = form2.returnValueID;
                        btnLogout.Enabled = true;
                        btnLogin.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                lblGuest.Text = "";
                throw;
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (guestID == 0)
            {
                System.Windows.Forms.MessageBox.Show("Kérlek jelentkezz be");
            }
            else
            {
                Form formBalance = new Form3(guestID);
                formBalance.Show();
            }


        }

        private void btnRoomService_Click(object sender, EventArgs e)
        {
            Form formService = new Form4(guestID);
            formService.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            guestID = 0;
            lblGuest.Text = "";
            btnLogout.Enabled = false;
            btnLogin.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }














    

