namespace administrare_hotel
{
    partial class Angajati_Adauga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Angajati_Adauga));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.angajati_nume = new System.Windows.Forms.TextBox();
            this.angajati_prenume = new System.Windows.Forms.TextBox();
            this.Angajati_Done = new System.Windows.Forms.Button();
            this.Angajati_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "prenume";
            // 
            // angajati_nume
            // 
            this.angajati_nume.Location = new System.Drawing.Point(66, 9);
            this.angajati_nume.Name = "angajati_nume";
            this.angajati_nume.Size = new System.Drawing.Size(100, 20);
            this.angajati_nume.TabIndex = 2;
            // 
            // angajati_prenume
            // 
            this.angajati_prenume.Location = new System.Drawing.Point(66, 35);
            this.angajati_prenume.Name = "angajati_prenume";
            this.angajati_prenume.Size = new System.Drawing.Size(100, 20);
            this.angajati_prenume.TabIndex = 3;
            // 
            // Angajati_Done
            // 
            this.Angajati_Done.Location = new System.Drawing.Point(488, 494);
            this.Angajati_Done.Name = "Angajati_Done";
            this.Angajati_Done.Size = new System.Drawing.Size(171, 53);
            this.Angajati_Done.TabIndex = 4;
            this.Angajati_Done.Text = "Done";
            this.Angajati_Done.UseVisualStyleBackColor = true;
            this.Angajati_Done.Click += new System.EventHandler(this.Angajati_Done_Click);
            // 
            // Angajati_Close
            // 
            this.Angajati_Close.Location = new System.Drawing.Point(218, 494);
            this.Angajati_Close.Name = "Angajati_Close";
            this.Angajati_Close.Size = new System.Drawing.Size(171, 53);
            this.Angajati_Close.TabIndex = 5;
            this.Angajati_Close.Text = "Close";
            this.Angajati_Close.UseVisualStyleBackColor = true;
            this.Angajati_Close.Click += new System.EventHandler(this.Angajati_Close_Click);
            // 
            // Angajati_Adauga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 593);
            this.Controls.Add(this.Angajati_Close);
            this.Controls.Add(this.Angajati_Done);
            this.Controls.Add(this.angajati_prenume);
            this.Controls.Add(this.angajati_nume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Angajati_Adauga";
            this.Text = "Angajati_Adauga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox angajati_nume;
        private System.Windows.Forms.TextBox angajati_prenume;
        private System.Windows.Forms.Button Angajati_Done;
        private System.Windows.Forms.Button Angajati_Close;
    }
}