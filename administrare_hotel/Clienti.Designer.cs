namespace administrare_hotel
{
    partial class Clienti
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
            this.date_clienti = new System.Windows.Forms.DataGridView();
            this.buton_adaugaCLienti = new System.Windows.Forms.Button();
            this.buton_modificaClienti = new System.Windows.Forms.Button();
            this.buton_stergeClienti = new System.Windows.Forms.Button();
            this.buton_iesireClienti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.date_clienti)).BeginInit();
            this.SuspendLayout();
            // 
            // date_clienti
            // 
            this.date_clienti.BackgroundColor = System.Drawing.SystemColors.Control;
            this.date_clienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.date_clienti.Location = new System.Drawing.Point(12, 78);
            this.date_clienti.Name = "date_clienti";
            this.date_clienti.Size = new System.Drawing.Size(584, 421);
            this.date_clienti.TabIndex = 0;
            // 
            // buton_adaugaCLienti
            // 
            this.buton_adaugaCLienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_adaugaCLienti.Location = new System.Drawing.Point(602, 78);
            this.buton_adaugaCLienti.Name = "buton_adaugaCLienti";
            this.buton_adaugaCLienti.Size = new System.Drawing.Size(130, 60);
            this.buton_adaugaCLienti.TabIndex = 1;
            this.buton_adaugaCLienti.Text = "Adauga";
            this.buton_adaugaCLienti.UseVisualStyleBackColor = true;
            // 
            // buton_modificaClienti
            // 
            this.buton_modificaClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_modificaClienti.Location = new System.Drawing.Point(602, 144);
            this.buton_modificaClienti.Name = "buton_modificaClienti";
            this.buton_modificaClienti.Size = new System.Drawing.Size(130, 60);
            this.buton_modificaClienti.TabIndex = 2;
            this.buton_modificaClienti.Text = "Modifica";
            this.buton_modificaClienti.UseVisualStyleBackColor = true;
            // 
            // buton_stergeClienti
            // 
            this.buton_stergeClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_stergeClienti.Location = new System.Drawing.Point(602, 210);
            this.buton_stergeClienti.Name = "buton_stergeClienti";
            this.buton_stergeClienti.Size = new System.Drawing.Size(130, 60);
            this.buton_stergeClienti.TabIndex = 3;
            this.buton_stergeClienti.Text = "Sterge";
            this.buton_stergeClienti.UseVisualStyleBackColor = true;
            // 
            // buton_iesireClienti
            // 
            this.buton_iesireClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_iesireClienti.Location = new System.Drawing.Point(602, 439);
            this.buton_iesireClienti.Name = "buton_iesireClienti";
            this.buton_iesireClienti.Size = new System.Drawing.Size(130, 60);
            this.buton_iesireClienti.TabIndex = 4;
            this.buton_iesireClienti.Text = "Iesire";
            this.buton_iesireClienti.UseVisualStyleBackColor = true;
            this.buton_iesireClienti.Click += new System.EventHandler(this.buton_iesireClienti_Click);
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(744, 511);
            this.ControlBox = false;
            this.Controls.Add(this.buton_iesireClienti);
            this.Controls.Add(this.buton_stergeClienti);
            this.Controls.Add(this.buton_modificaClienti);
            this.Controls.Add(this.buton_adaugaCLienti);
            this.Controls.Add(this.date_clienti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienti";
            ((System.ComponentModel.ISupportInitialize)(this.date_clienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView date_clienti;
        private System.Windows.Forms.Button buton_adaugaCLienti;
        private System.Windows.Forms.Button buton_modificaClienti;
        private System.Windows.Forms.Button buton_stergeClienti;
        private System.Windows.Forms.Button buton_iesireClienti;
    }
}