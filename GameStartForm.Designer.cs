namespace Pacman_Game
{
    partial class GameStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameStartForm));
            this.btnHard = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuide = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPac2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPac1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPac2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPac1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Red;
            this.btnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(397, 248);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(180, 90);
            this.btnHard.TabIndex = 0;
            this.btnHard.Text = "Cao thủ (Khó)";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.Lime;
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(94, 248);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(180, 89);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "Tân binh (Dễ)";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(148, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mời bạn chọn chế độ chơi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(220, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hướng dẫn chơi";
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuide.Location = new System.Drawing.Point(279, 402);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(124, 50);
            this.btnGuide.TabIndex = 4;
            this.btnGuide.Text = "Guide";
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pacman_Game.Properties.Resources.buttonFrame;
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPac2
            // 
            this.pictureBoxPac2.Image = global::Pacman_Game.Properties.Resources.left;
            this.pictureBoxPac2.Location = new System.Drawing.Point(583, 257);
            this.pictureBoxPac2.Name = "pictureBoxPac2";
            this.pictureBoxPac2.Size = new System.Drawing.Size(87, 81);
            this.pictureBoxPac2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPac2.TabIndex = 5;
            this.pictureBoxPac2.TabStop = false;
            // 
            // pictureBoxPac1
            // 
            this.pictureBoxPac1.Image = global::Pacman_Game.Properties.Resources.right;
            this.pictureBoxPac1.Location = new System.Drawing.Point(1, 257);
            this.pictureBoxPac1.Name = "pictureBoxPac1";
            this.pictureBoxPac1.Size = new System.Drawing.Size(87, 81);
            this.pictureBoxPac1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPac1.TabIndex = 5;
            this.pictureBoxPac1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(186, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(313, 97);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Welcome to Pacman 2BCD";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxPac2);
            this.Controls.Add(this.pictureBoxPac1);
            this.Controls.Add(this.btnGuide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameStartForm";
            this.Text = "Pacman 2BCD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPac2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPac1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.PictureBox pictureBoxPac1;
        private System.Windows.Forms.PictureBox pictureBoxPac2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}