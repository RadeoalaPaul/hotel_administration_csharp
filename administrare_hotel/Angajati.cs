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
    public partial class Angajati : Form
    {

        Form1 principal = new Form1();

        public Angajati()
        {
            InitializeComponent();
        }

        private void buton_iesireAngajati_Click(object sender, EventArgs e)
        {
            //afisare + verificare raspuns mesaj, revenire la form principal

            DialogResult mesaj;
            mesaj = MessageBox.Show("Doresti sa iesi din sectiunea Angajati?", "Iesire",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (mesaj == DialogResult.Yes)
            {
                principal.Show();
                this.Close();
            }
            else { };

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        }

        private void Angajati_Load(object sender, EventArgs e)
        {
         
        }
    }
}
