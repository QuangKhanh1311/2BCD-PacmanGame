namespace Pacman_Game
{
    partial class GameGuideForm
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
            this.CharInfor = new System.Windows.Forms.Button();
            this.HowToPlay = new System.Windows.Forms.Button();
            this.HowToWin = new System.Windows.Forms.Button();
            this.Mode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CharInfor
            // 
            this.CharInfor.BackColor = System.Drawing.Color.Black;
            this.CharInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharInfor.ForeColor = System.Drawing.Color.White;
            this.CharInfor.Location = new System.Drawing.Point(12, 87);
            this.CharInfor.Name = "CharInfor";
            this.CharInfor.Size = new System.Drawing.Size(198, 61);
            this.CharInfor.TabIndex = 0;
            this.CharInfor.Text = "Thông tin các nhân vật";
            this.CharInfor.UseVisualStyleBackColor = false;
            this.CharInfor.Click += new System.EventHandler(this.CharInfor_Click);
            // 
            // HowToPlay
            // 
            this.HowToPlay.BackColor = System.Drawing.Color.Black;
            this.HowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToPlay.ForeColor = System.Drawing.Color.White;
            this.HowToPlay.Location = new System.Drawing.Point(12, 181);
            this.HowToPlay.Name = "HowToPlay";
            this.HowToPlay.Size = new System.Drawing.Size(198, 61);
            this.HowToPlay.TabIndex = 0;
            this.HowToPlay.Text = "Cách di chuyển";
            this.HowToPlay.UseVisualStyleBackColor = false;
            this.HowToPlay.Click += new System.EventHandler(this.HowToPlay_Click);
            // 
            // HowToWin
            // 
            this.HowToWin.BackColor = System.Drawing.Color.Black;
            this.HowToWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToWin.ForeColor = System.Drawing.Color.White;
            this.HowToWin.Location = new System.Drawing.Point(12, 282);
            this.HowToWin.Name = "HowToWin";
            this.HowToWin.Size = new System.Drawing.Size(198, 61);
            this.HowToWin.TabIndex = 0;
            this.HowToWin.Text = "Cách chiến thắng";
            this.HowToWin.UseVisualStyleBackColor = false;
            this.HowToWin.Click += new System.EventHandler(this.HowToWin_Click);
            // 
            // Mode
            // 
            this.Mode.BackColor = System.Drawing.Color.Black;
            this.Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.ForeColor = System.Drawing.Color.White;
            this.Mode.Location = new System.Drawing.Point(12, 387);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(198, 61);
            this.Mode.TabIndex = 0;
            this.Mode.Text = "Các chế độ";
            this.Mode.UseVisualStyleBackColor = false;
            this.Mode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // GameGuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.HowToWin);
            this.Controls.Add(this.HowToPlay);
            this.Controls.Add(this.CharInfor);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameGuideForm";
            this.Text = "GameGuideForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CharInfor;
        private System.Windows.Forms.Button HowToPlay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HowToWin;
        private System.Windows.Forms.Button Mode;
    }
}