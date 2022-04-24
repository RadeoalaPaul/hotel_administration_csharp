using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace administrare_hotel
{
    public partial class Camere : Form
    {
        Form1 principal = new Form1();
        MySqlConnection conn = new MySqlConnection();
        public string data;

        public Camere()
        {
            InitializeComponent();
        }

        public void Conexiune()
        {
            string connection_string = @"server = localhost; port = 3306; database = hotel_database; user = root; password =";
            conn.ConnectionString = connection_string;
            conn.Open();
        }

        private void buton_iesireCamere_Click(object sender, EventArgs e)
        {
            DialogResult mesaj;
            mesaj = MessageBox.Show("Doresti sa iesi din sectiunea Camere?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mesaj == DialogResult.Yes)
            {
                principal.Show();
                this.Close();
            }
        }

        private void nav_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titlu aplicatie: 'Administrare hotel'\nLimbaje folosite: MySQL & C#\nElev: Radeoala Paul\nProfesor coordonator: Babutia Teodora", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void nav_camere_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aici poti adauga/modifica/sterge date despre camerele hotelului", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Camere_Load(object sender, EventArgs e)
        {
            Conexiune();
            try
            {
                DataTable tabel_date_camere = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM camere", conn);
                adapter.Fill(tabel_date_camere);
                date_camere.DataSource = tabel_date_camere;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buton_adaugaCamere_Click(object sender, EventArgs e)
        {
            adaugaCamere adauga = new adaugaCamere();
            this.Close();
            adauga.Show();
        }


        private void buton_stergeCamere_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < date_camere.Rows.Count; i++)
            {
                if (date_camere.Rows[i].Selected == true)
                {
                    try
                    {
                        Conexiune();
                        string query = "DELETE FROM camere WHERE Numar = '" + date_camere.Rows[i].Cells[0].FormattedValue.ToString() + "';";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        DataTable tabel_date_camere = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM camere", conn);
                        adapter.Fill(tabel_date_camere);
                        date_camere.DataSource = tabel_date_camere;
                        MessageBox.Show("Ati sters aceasta inregistrare din baza de date.", "Stergere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void buton_modificaCamere_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < date_camere.Rows.Count; i++)
            {
                if (date_camere.Rows[i].Selected == true)
                {
                    modificaCamere modifica = new modificaCamere();
                    modifica.data(date_camere.Rows[i].Cells[0].FormattedValue.ToString(), "ID");
                    modifica.data(date_camere.Rows[i].Cells[1].FormattedValue.ToString(), "frigider");
                    modifica.data(date_camere.Rows[i].Cells[3].FormattedValue.ToString(), "Pat dublu");
                    this.Close();
                    modifica.Show();
                }
            }
        }
    }
}
