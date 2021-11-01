namespace administrare_hotel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buton_Angajati = new System.Windows.Forms.Button();
            this.buton_Camere = new System.Windows.Forms.Button();
            this.buton_Rezervari = new System.Windows.Forms.Button();
            this.buton_Iesire = new System.Windows.Forms.Button();
            this.buton_Clienti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buton_Angajati
            // 
            this.buton_Angajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Angajati.Location = new System.Drawing.Point(12, 124);
            this.buton_Angajati.Name = "buton_Angajati";
            this.buton_Angajati.Size = new System.Drawing.Size(220, 100);
            this.buton_Angajati.TabIndex = 0;
            this.buton_Angajati.Text = "Angajati";
            this.buton_Angajati.UseVisualStyleBackColor = true;
            this.buton_Angajati.Click += new System.EventHandler(this.buton_Angajati_Click);
            // 
            // buton_Camere
            // 
            this.buton_Camere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Camere.Location = new System.Drawing.Point(238, 232);
            this.buton_Camere.Name = "buton_Camere";
            this.buton_Camere.Size = new System.Drawing.Size(220, 100);
            this.buton_Camere.TabIndex = 2;
            this.buton_Camere.Text = "Camere";
            this.buton_Camere.UseVisualStyleBackColor = true;
            this.buton_Camere.Click += new System.EventHandler(this.buton_Camere_Click);
            // 
            // buton_Rezervari
            // 
            this.buton_Rezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Rezervari.Location = new System.Drawing.Point(12, 232);
            this.buton_Rezervari.Name = "buton_Rezervari";
            this.buton_Rezervari.Size = new System.Drawing.Size(220, 100);
            this.buton_Rezervari.TabIndex = 3;
            this.buton_Rezervari.Text = "Rezervari";
            this.buton_Rezervari.UseVisualStyleBackColor = true;
            this.buton_Rezervari.Click += new System.EventHandler(this.buton_Rezervari_Click);
            // 
            // buton_Iesire
            // 
            this.buton_Iesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_Iesire.Location = new System.Drawing.Point(92, 388);
            this.buton_Iesire.Name = "buton_Iesire";
            this.buton_Iesire.Size = new System.Drawing.Size(280, 80);
            this.buton_Iesire.TabIndex = 4;
            this.buton_Iesire.Text = "Iesire";
            this.buton_Iesire.UseVisualStyleBackColor = true;
            this.buton_Iesire.Click += new System.EventHandler(this.buton_Iesire_Click);
            // 
            // buton_Clienti
            // 
            this.buton_Clienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Clienti.Location = new System.Drawing.Point(239, 124);
            this.buton_Clienti.Name = "buton_Clienti";
            this.buton_Clienti.Size = new System.Drawing.Size(220, 100);
            this.buton_Clienti.TabIndex = 5;
            this.buton_Clienti.Text = "Clienti";
            this.buton_Clienti.UseVisualStyleBackColor = true;
            this.buton_Clienti.Click += new System.EventHandler(this.buton_Clienti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(471, 481);
            this.ControlBox = false;
            this.Controls.Add(this.buton_Clienti);
            this.Controls.Add(this.buton_Iesire);
            this.Controls.Add(this.buton_Rezervari);
            this.Controls.Add(this.buton_Camere);
            this.Controls.Add(this.buton_Angajati);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "administrare_hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buton_Angajati;
        private System.Windows.Forms.Button buton_Camere;
        private System.Windows.Forms.Button buton_Rezervari;
        private System.Windows.Forms.Button buton_Iesire;
        private System.Windows.Forms.Button buton_Clienti;
    }
}

