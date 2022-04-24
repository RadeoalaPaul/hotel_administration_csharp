namespace administrare_hotel
{
    partial class adaugaRezervari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adaugaRezervari));
            this.buton_IesireAdaugaRezervari = new System.Windows.Forms.Button();
            this.buton_adaugaRezervariSalvare = new System.Windows.Forms.Button();
            this.text_adaugaRezervari_numar_camera = new System.Windows.Forms.TextBox();
            this.text_adaugaRezervari_id_client = new System.Windows.Forms.TextBox();
            this.label_numar_camera = new System.Windows.Forms.Label();
            this.label_id_client = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buton_IesireAdaugaRezervari
            // 
            this.buton_IesireAdaugaRezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_IesireAdaugaRezervari.Location = new System.Drawing.Point(91, 210);
            this.buton_IesireAdaugaRezervari.Name = "buton_IesireAdaugaRezervari";
            this.buton_IesireAdaugaRezervari.Size = new System.Drawing.Size(101, 33);
            this.buton_IesireAdaugaRezervari.TabIndex = 12;
            this.buton_IesireAdaugaRezervari.Text = "Iesire";
            this.buton_IesireAdaugaRezervari.UseVisualStyleBackColor = true;
            this.buton_IesireAdaugaRezervari.Click += new System.EventHandler(this.buton_IesireAdaugaRezervari_Click);
            // 
            // buton_adaugaRezervariSalvare
            // 
            this.buton_adaugaRezervariSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_adaugaRezervariSalvare.Location = new System.Drawing.Point(91, 171);
            this.buton_adaugaRezervariSalvare.Name = "buton_adaugaRezervariSalvare";
            this.buton_adaugaRezervariSalvare.Size = new System.Drawing.Size(101, 33);
            this.buton_adaugaRezervariSalvare.TabIndex = 13;
            this.buton_adaugaRezervariSalvare.Text = "Salvare";
            this.buton_adaugaRezervariSalvare.UseVisualStyleBackColor = true;
            this.buton_adaugaRezervariSalvare.Click += new System.EventHandler(this.buton_adaugaRezervariSalvare_Click);
            // 
            // text_adaugaRezervari_numar_camera
            // 
            this.text_adaugaRezervari_numar_camera.Location = new System.Drawing.Point(82, 77);
            this.text_adaugaRezervari_numar_camera.Name = "text_adaugaRezervari_numar_camera";
            this.text_adaugaRezervari_numar_camera.Size = new System.Drawing.Size(186, 20);
            this.text_adaugaRezervari_numar_camera.TabIndex = 16;
            // 
            // text_adaugaRezervari_id_client
            // 
            this.text_adaugaRezervari_id_client.Location = new System.Drawing.Point(67, 51);
            this.text_adaugaRezervari_id_client.Name = "text_adaugaRezervari_id_client";
            this.text_adaugaRezervari_id_client.Size = new System.Drawing.Size(186, 20);
            this.text_adaugaRezervari_id_client.TabIndex = 17;
            // 
            // label_numar_camera
            // 
            this.label_numar_camera.AutoSize = true;
            this.label_numar_camera.Location = new System.Drawing.Point(0, 77);
            this.label_numar_camera.Name = "label_numar_camera";
            this.label_numar_camera.Size = new System.Drawing.Size(76, 13);
            this.label_numar_camera.TabIndex = 20;
            this.label_numar_camera.Text = "Numar camera";
            // 
            // label_id_client
            // 
            this.label_id_client.AutoSize = true;
            this.label_id_client.Location = new System.Drawing.Point(12, 54);
            this.label_id_client.Name = "label_id_client";
            this.label_id_client.Size = new System.Drawing.Size(47, 13);
            this.label_id_client.TabIndex = 21;
            this.label_id_client.Text = "ID Client";
            // 
            // adaugaRezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 255);
            this.Controls.Add(this.label_id_client);
            this.Controls.Add(this.label_numar_camera);
            this.Controls.Add(this.text_adaugaRezervari_id_client);
            this.Controls.Add(this.text_adaugaRezervari_numar_camera);
            this.Controls.Add(this.buton_adaugaRezervariSalvare);
            this.Controls.Add(this.buton_IesireAdaugaRezervari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adaugaRezervari";
            this.Text = "adaugaRezervari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buton_IesireAdaugaRezervari;
        private System.Windows.Forms.Button buton_adaugaRezervariSalvare;
        private System.Windows.Forms.TextBox text_adaugaRezervari_numar_camera;
        private System.Windows.Forms.TextBox text_adaugaRezervari_id_client;
        private System.Windows.Forms.Label label_numar_camera;
        private System.Windows.Forms.Label label_id_client;
    }
}