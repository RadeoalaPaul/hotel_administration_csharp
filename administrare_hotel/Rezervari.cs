﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administrare_hotel
{

    public partial class Rezervari : Form
    {

        Form1 principal = new Form1();

        public Rezervari()
        {
            InitializeComponent();
        }

        private void buton_iesireRezervari_Click(object sender, EventArgs e)
        {
            DialogResult mesaj;
            mesaj = MessageBox.Show("Doresti sa iesi din sectiunea Rezervari?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mesaj == DialogResult.Yes)
            {
                principal.Show();
                this.Close();
            }
            else { };
        }

        private void nav_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titlu aplicatie: 'Administrare hotel'\nLimbaje folosite: MySQL & C#\nElev: Radeoala Paul\nProfesor coordonator: Babutia Teodora", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void nav_rezervari_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aici poti adauga/modifica/sterge date despre rezervarile facute de catre clienti", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
