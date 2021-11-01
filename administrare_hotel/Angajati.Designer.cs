namespace administrare_hotel
{
    partial class Angajati
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
            this.date_angajati = new System.Windows.Forms.DataGridView();
            this.buton_adaugaAngajati = new System.Windows.Forms.Button();
            this.buton_modificaAngajati = new System.Windows.Forms.Button();
            this.buton_stergeAngajati = new System.Windows.Forms.Button();
            this.buton_iesireAngajati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.date_angajati)).BeginInit();
            this.SuspendLayout();
            // 
            // date_angajati
            // 
            this.date_angajati.AllowUserToOrderColumns = true;
            this.date_angajati.BackgroundColor = System.Drawing.SystemColors.Control;
            this.date_angajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.date_angajati.Location = new System.Drawing.Point(12, 78);
            this.date_angajati.Name = "date_angajati";
            this.date_angajati.Size = new System.Drawing.Size(584, 421);
            this.date_angajati.TabIndex = 0;
            // 
            // buton_adaugaAngajati
            // 
            this.buton_adaugaAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_adaugaAngajati.Location = new System.Drawing.Point(602, 78);
            this.buton_adaugaAngajati.Name = "buton_adaugaAngajati";
            this.buton_adaugaAngajati.Size = new System.Drawing.Size(130, 60);
            this.buton_adaugaAngajati.TabIndex = 1;
            this.buton_adaugaAngajati.Text = "Adauga";
            this.buton_adaugaAngajati.UseVisualStyleBackColor = true;
            // 
            // buton_modificaAngajati
            // 
            this.buton_modificaAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_modificaAngajati.Location = new System.Drawing.Point(602, 144);
            this.buton_modificaAngajati.Name = "buton_modificaAngajati";
            this.buton_modificaAngajati.Size = new System.Drawing.Size(130, 60);
            this.buton_modificaAngajati.TabIndex = 2;
            this.buton_modificaAngajati.Text = "Modifica";
            this.buton_modificaAngajati.UseVisualStyleBackColor = true;
            // 
            // buton_stergeAngajati
            // 
            this.buton_stergeAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_stergeAngajati.Location = new System.Drawing.Point(602, 210);
            this.buton_stergeAngajati.Name = "buton_stergeAngajati";
            this.buton_stergeAngajati.Size = new System.Drawing.Size(130, 60);
            this.buton_stergeAngajati.TabIndex = 3;
            this.buton_stergeAngajati.Text = "Sterge";
            this.buton_stergeAngajati.UseVisualStyleBackColor = true;
            // 
            // buton_iesireAngajati
            // 
            this.buton_iesireAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_iesireAngajati.Location = new System.Drawing.Point(602, 439);
            this.buton_iesireAngajati.Name = "buton_iesireAngajati";
            this.buton_iesireAngajati.Size = new System.Drawing.Size(130, 60);
            this.buton_iesireAngajati.TabIndex = 4;
            this.buton_iesireAngajati.Text = "Iesire";
            this.buton_iesireAngajati.UseVisualStyleBackColor = true;
            this.buton_iesireAngajati.Click += new System.EventHandler(this.buton_iesireAngajati_Click);
            // 
            // Angajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(744, 511);
            this.ControlBox = false;
            this.Controls.Add(this.buton_iesireAngajati);
            this.Controls.Add(this.buton_stergeAngajati);
            this.Controls.Add(this.buton_modificaAngajati);
            this.Controls.Add(this.buton_adaugaAngajati);
            this.Controls.Add(this.date_angajati);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Angajati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angajati";
            this.Load += new System.EventHandler(this.Angajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date_angajati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView date_angajati;
        private System.Windows.Forms.Button buton_adaugaAngajati;
        private System.Windows.Forms.Button buton_modificaAngajati;
        private System.Windows.Forms.Button buton_stergeAngajati;
        private System.Windows.Forms.Button buton_iesireAngajati;
    }
}