namespace administrare_hotel
{
    partial class Rezervari
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
            this.date_rezervari = new System.Windows.Forms.DataGridView();
            this.buton_adaugaRezervari = new System.Windows.Forms.Button();
            this.buton_modificaRezervari = new System.Windows.Forms.Button();
            this.buton_stergeRezervari = new System.Windows.Forms.Button();
            this.buton_iesireRezervari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.date_rezervari)).BeginInit();
            this.SuspendLayout();
            // 
            // date_rezervari
            // 
            this.date_rezervari.BackgroundColor = System.Drawing.SystemColors.Control;
            this.date_rezervari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.date_rezervari.Location = new System.Drawing.Point(12, 82);
            this.date_rezervari.Name = "date_rezervari";
            this.date_rezervari.Size = new System.Drawing.Size(584, 421);
            this.date_rezervari.TabIndex = 0;
            // 
            // buton_adaugaRezervari
            // 
            this.buton_adaugaRezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_adaugaRezervari.Location = new System.Drawing.Point(606, 82);
            this.buton_adaugaRezervari.Name = "buton_adaugaRezervari";
            this.buton_adaugaRezervari.Size = new System.Drawing.Size(130, 60);
            this.buton_adaugaRezervari.TabIndex = 1;
            this.buton_adaugaRezervari.Text = "Adauga";
            this.buton_adaugaRezervari.UseVisualStyleBackColor = true;
            // 
            // buton_modificaRezervari
            // 
            this.buton_modificaRezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_modificaRezervari.Location = new System.Drawing.Point(606, 148);
            this.buton_modificaRezervari.Name = "buton_modificaRezervari";
            this.buton_modificaRezervari.Size = new System.Drawing.Size(130, 60);
            this.buton_modificaRezervari.TabIndex = 2;
            this.buton_modificaRezervari.Text = "Modifica";
            this.buton_modificaRezervari.UseVisualStyleBackColor = true;
            // 
            // buton_stergeRezervari
            // 
            this.buton_stergeRezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_stergeRezervari.Location = new System.Drawing.Point(606, 214);
            this.buton_stergeRezervari.Name = "buton_stergeRezervari";
            this.buton_stergeRezervari.Size = new System.Drawing.Size(130, 60);
            this.buton_stergeRezervari.TabIndex = 3;
            this.buton_stergeRezervari.Text = "Sterge";
            this.buton_stergeRezervari.UseVisualStyleBackColor = true;
            // 
            // buton_iesireRezervari
            // 
            this.buton_iesireRezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_iesireRezervari.Location = new System.Drawing.Point(606, 443);
            this.buton_iesireRezervari.Name = "buton_iesireRezervari";
            this.buton_iesireRezervari.Size = new System.Drawing.Size(130, 60);
            this.buton_iesireRezervari.TabIndex = 4;
            this.buton_iesireRezervari.Text = "Iesire";
            this.buton_iesireRezervari.UseVisualStyleBackColor = true;
            this.buton_iesireRezervari.Click += new System.EventHandler(this.buton_iesireRezervari_Click);
            // 
            // Rezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(748, 515);
            this.ControlBox = false;
            this.Controls.Add(this.buton_iesireRezervari);
            this.Controls.Add(this.buton_stergeRezervari);
            this.Controls.Add(this.buton_modificaRezervari);
            this.Controls.Add(this.buton_adaugaRezervari);
            this.Controls.Add(this.date_rezervari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rezervari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervari";
            ((System.ComponentModel.ISupportInitialize)(this.date_rezervari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView date_rezervari;
        private System.Windows.Forms.Button buton_adaugaRezervari;
        private System.Windows.Forms.Button buton_modificaRezervari;
        private System.Windows.Forms.Button buton_stergeRezervari;
        private System.Windows.Forms.Button buton_iesireRezervari;
    }
}