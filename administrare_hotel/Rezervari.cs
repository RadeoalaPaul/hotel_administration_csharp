using System;
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
    }
}
