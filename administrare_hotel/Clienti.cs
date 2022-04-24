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
    public partial class Clienti : Form
    {
        Form1 principal = new Form1();
        MySqlConnection conn = new MySqlConnection();
        public string data;

        public Clienti()
        {
            InitializeComponent();
        }

        public void Conexiune()
        {
            string connection_string = @"server = localhost; port = 3306; database = hotel_database; user = root; password =";
            conn.ConnectionString = connection_string;
            conn.Open();
        }

        private void buton_iesireClienti_Click(object sender, EventArgs e)
        {
            DialogResult mesaj;
            mesaj = MessageBox.Show("Doresti sa iesi din sectiunea Clienti?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void nav_clienti_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In aceasta sectiune poti adauga/modifica/sterge date despre clientii care au rezervat una dintre camerele hotelului", "Help", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Clienti_Load(object sender, EventArgs e)
        {
            Conexiune();
            try
            {
                DataTable tabel_date_clienti = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM clienti", conn);
                adapter.Fill(tabel_date_clienti);
                date_clienti.DataSource = tabel_date_clienti;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buton_adaugaCLienti_Click(object sender, EventArgs e)
        {
            adaugaClienti adauga = new adaugaClienti();
            this.Close();
            adauga.Show();
        }

        private void buton_stergeClienti_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < date_clienti.Rows.Count; i++)
            {
                if (date_clienti.Rows[i].Selected == true)
                {
                    try
                    {
                        Conexiune();
                        string query = "DELETE FROM clienti WHERE CNP = '" + date_clienti.Rows[i].Cells[4].FormattedValue.ToString() + "';";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        DataTable tabel_date_clienti = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM clienti", conn);
                        adapter.Fill(tabel_date_clienti);
                        date_clienti.DataSource = tabel_date_clienti;
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

        private void buton_modificaClienti_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < date_clienti.Rows.Count; i++)
            {
                if (date_clienti.Rows[i].Selected == true)
                {
                    modificaClienti modifica = new modificaClienti();
                    modifica.data(date_clienti.Rows[i].Cells[0].FormattedValue.ToString(), "ID");
                    modifica.data(date_clienti.Rows[i].Cells[1].FormattedValue.ToString(), "nume");
                    modifica.data(date_clienti.Rows[i].Cells[2].FormattedValue.ToString(), "prenume");
                    modifica.data(date_clienti.Rows[i].Cells[3].FormattedValue.ToString(), "telefon");
                    this.Close();
                    modifica.Show();
                }
            }
        }
    }
}
