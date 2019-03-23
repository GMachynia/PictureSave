namespace PictureSave
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.RotateBtn = new System.Windows.Forms.Button();
            this.SavePicBtn = new System.Windows.Forms.Button();
            this.NextPicBtn = new System.Windows.Forms.Button();
            this.PreviousPicBtn = new System.Windows.Forms.Button();
            this.ChooseDestBtn = new System.Windows.Forms.Button();
            this.ChooseDestLabel = new System.Windows.Forms.Label();
            this.ChooseSourceLabel = new System.Windows.Forms.Label();
            this.ChooseSourceBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.RotateBtn);
            this.panel1.Controls.Add(this.SavePicBtn);
            this.panel1.Controls.Add(this.NextPicBtn);
            this.panel1.Controls.Add(this.PreviousPicBtn);
            this.panel1.Controls.Add(this.ChooseDestBtn);
            this.panel1.Controls.Add(this.ChooseDestLabel);
            this.panel1.Controls.Add(this.ChooseSourceLabel);
            this.panel1.Controls.Add(this.ChooseSourceBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1154, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 895);
            this.panel1.TabIndex = 0;
            // 
            // RotateBtn
            // 
            this.RotateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RotateBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RotateBtn.Location = new System.Drawing.Point(22, 388);
            this.RotateBtn.Name = "RotateBtn";
            this.RotateBtn.Size = new System.Drawing.Size(379, 84);
            this.RotateBtn.TabIndex = 14;
            this.RotateBtn.Text = "Rotate picture";
            this.RotateBtn.UseVisualStyleBackColor = true;
            this.RotateBtn.Click += new System.EventHandler(this.RotateBtn_Click);
            // 
            // SavePicBtn
            // 
            this.SavePicBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SavePicBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SavePicBtn.Location = new System.Drawing.Point(126, 571);
            this.SavePicBtn.Name = "SavePicBtn";
            this.SavePicBtn.Size = new System.Drawing.Size(175, 144);
            this.SavePicBtn.TabIndex = 13;
            this.SavePicBtn.Text = "Save picture";
            this.SavePicBtn.UseVisualStyleBackColor = true;
            this.SavePicBtn.Click += new System.EventHandler(this.SavePicBtn_Click);
            // 
            // NextPicBtn
            // 
            this.NextPicBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NextPicBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NextPicBtn.Location = new System.Drawing.Point(323, 571);
            this.NextPicBtn.Name = "NextPicBtn";
            this.NextPicBtn.Size = new System.Drawing.Size(78, 144);
            this.NextPicBtn.TabIndex = 12;
            this.NextPicBtn.Text = ">";
            this.NextPicBtn.UseVisualStyleBackColor = true;
            this.NextPicBtn.Click += new System.EventHandler(this.NextPicBtn_Click);
            // 
            // PreviousPicBtn
            // 
            this.PreviousPicBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PreviousPicBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PreviousPicBtn.Location = new System.Drawing.Point(22, 571);
            this.PreviousPicBtn.Name = "PreviousPicBtn";
            this.PreviousPicBtn.Size = new System.Drawing.Size(78, 144);
            this.PreviousPicBtn.TabIndex = 11;
            this.PreviousPicBtn.Text = "<";
            this.PreviousPicBtn.UseVisualStyleBackColor = true;
            this.PreviousPicBtn.Click += new System.EventHandler(this.PreviousPicBtn_Click);
            // 
            // ChooseDestBtn
            // 
            this.ChooseDestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChooseDestBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChooseDestBtn.Location = new System.Drawing.Point(9, 216);
            this.ChooseDestBtn.Name = "ChooseDestBtn";
            this.ChooseDestBtn.Size = new System.Drawing.Size(292, 53);
            this.ChooseDestBtn.TabIndex = 9;
            this.ChooseDestBtn.Text = "Choose path";
            this.ChooseDestBtn.UseVisualStyleBackColor = true;
            this.ChooseDestBtn.Click += new System.EventHandler(this.ChooseDestBtn_Click);
            // 
            // ChooseDestLabel
            // 
            this.ChooseDestLabel.AutoSize = true;
            this.ChooseDestLabel.BackColor = System.Drawing.SystemColors.Window;
            this.ChooseDestLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChooseDestLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChooseDestLabel.Location = new System.Drawing.Point(7, 292);
            this.ChooseDestLabel.Name = "ChooseDestLabel";
            this.ChooseDestLabel.Size = new System.Drawing.Size(20, 17);
            this.ChooseDestLabel.TabIndex = 8;
            this.ChooseDestLabel.Text = "...";
            // 
            // ChooseSourceLabel
            // 
            this.ChooseSourceLabel.AutoSize = true;
            this.ChooseSourceLabel.BackColor = System.Drawing.SystemColors.Window;
            this.ChooseSourceLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChooseSourceLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChooseSourceLabel.Location = new System.Drawing.Point(7, 134);
            this.ChooseSourceLabel.Name = "ChooseSourceLabel";
            this.ChooseSourceLabel.Size = new System.Drawing.Size(20, 17);
            this.ChooseSourceLabel.TabIndex = 7;
            this.ChooseSourceLabel.Text = "...";
            // 
            // ChooseSourceBtn
            // 
            this.ChooseSourceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChooseSourceBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChooseSourceBtn.Location = new System.Drawing.Point(10, 62);
            this.ChooseSourceBtn.Name = "ChooseSourceBtn";
            this.ChooseSourceBtn.Size = new System.Drawing.Size(292, 53);
            this.ChooseSourceBtn.TabIndex = 5;
            this.ChooseSourceBtn.Text = "Choose path";
            this.ChooseSourceBtn.UseVisualStyleBackColor = true;
            this.ChooseSourceBtn.Click += new System.EventHandler(this.ChooseSourceBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExitBtn.Location = new System.Drawing.Point(311, 796);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(108, 86);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(7, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose the path to save pictures.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the path with pictures.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1154, 895);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1576, 895);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureSave";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ChooseDestBtn;
        private System.Windows.Forms.Label ChooseDestLabel;
        private System.Windows.Forms.Label ChooseSourceLabel;
        private System.Windows.Forms.Button ChooseSourceBtn;
        private System.Windows.Forms.Button SavePicBtn;
        private System.Windows.Forms.Button NextPicBtn;
        private System.Windows.Forms.Button PreviousPicBtn;
        private System.Windows.Forms.Button RotateBtn;
    }
}

