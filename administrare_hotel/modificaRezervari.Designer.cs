namespace administrare_hotel
{
    partial class modificaRezervari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificaRezervari));
            this.buton_IesireModificaRezervari = new System.Windows.Forms.Button();
            this.buton_modificaRezervariSalvare = new System.Windows.Forms.Button();
            this.text_modificaRezervari_numar_camera = new System.Windows.Forms.TextBox();
            this.label_numar_camera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buton_IesireModificaRezervari
            // 
            this.buton_IesireModificaRezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_IesireModificaRezervari.Location = new System.Drawing.Point(91, 210);
            this.buton_IesireModificaRezervari.Name = "buton_IesireModificaRezervari";
            this.buton_IesireModificaRezervari.Size = new System.Drawing.Size(101, 33);
            this.buton_IesireModificaRezervari.TabIndex = 13;
            this.buton_IesireModificaRezervari.Text = "Iesire";
            this.buton_IesireModificaRezervari.UseVisualStyleBackColor = true;
            this.buton_IesireModificaRezervari.Click += new System.EventHandler(this.buton_IesireModificaRezervari_Click);
            // 
            // buton_modificaRezervariSalvare
            // 
            this.buton_modificaRezervariSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_modificaRezervariSalvare.Location = new System.Drawing.Point(91, 171);
            this.buton_modificaRezervariSalvare.Name = "buton_modificaRezervariSalvare";
            this.buton_modificaRezervariSalvare.Size = new System.Drawing.Size(101, 33);
            this.buton_modificaRezervariSalvare.TabIndex = 14;
            this.buton_modificaRezervariSalvare.Text = "Salvare";
            this.buton_modificaRezervariSalvare.UseVisualStyleBackColor = true;
            this.buton_modificaRezervariSalvare.Click += new System.EventHandler(this.buton_modificaRezervariSalvare_Click);
            // 
            // text_modificaRezervari_numar_camera
            // 
            this.text_modificaRezervari_numar_camera.Location = new System.Drawing.Point(82, 77);
            this.text_modificaRezervari_numar_camera.Name = "text_modificaRezervari_numar_camera";
            this.text_modificaRezervari_numar_camera.Size = new System.Drawing.Size(186, 20);
            this.text_modificaRezervari_numar_camera.TabIndex = 17;
            // 
            // label_numar_camera
            // 
            this.label_numar_camera.AutoSize = true;
            this.label_numar_camera.Location = new System.Drawing.Point(0, 77);
            this.label_numar_camera.Name = "label_numar_camera";
            this.label_numar_camera.Size = new System.Drawing.Size(76, 13);
            this.label_numar_camera.TabIndex = 21;
            this.label_numar_camera.Text = "Numar camera";
            // 
            // modificaRezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 255);
            this.Controls.Add(this.label_numar_camera);
            this.Controls.Add(this.text_modificaRezervari_numar_camera);
            this.Controls.Add(this.buton_modificaRezervariSalvare);
            this.Controls.Add(this.buton_IesireModificaRezervari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modificaRezervari";
            this.Text = "modificaRezervari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buton_IesireModificaRezervari;
        private System.Windows.Forms.Button buton_modificaRezervariSalvare;
        private System.Windows.Forms.TextBox text_modificaRezervari_numar_camera;
        private System.Windows.Forms.Label label_numar_camera;
    }
}