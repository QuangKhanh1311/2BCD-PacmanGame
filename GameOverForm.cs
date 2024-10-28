using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_Game
{
    public partial class GameOverForm : Form
    {
        public bool playAgain {  get; private set; }
        private Button btnYes;
        private Button btnNo;
        private Label lbGameOver;
        private Label lbContinue;

        public GameOverForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Hàm thực hiện in ra các thông báo THÁNG, THUA và thông báo hỏi ý kiến người chơi
        /// </summary>
        /// <param name="gameMessage"></param>
        /// <param name="colourType"></param>
        public void ShowGameOver(string gameMessage,char colourType)
        {
            lbGameOver = new Label();
            lbGameOver.Font = new Font("Arial", 18, FontStyle.Bold);
            lbGameOver.AutoSize = true;
            if(colourType == 'R')
                lbGameOver.ForeColor = Color.Red;
            else if(colourType == 'G')
                lbGameOver.ForeColor = Color.Green;
            else 
                lbGameOver.ForeColor = Color.Yellow;

            lbGameOver.Text = gameMessage;
            pictureBox1.Controls.Add(lbGameOver);

            lbGameOver.Location = new Point(
                (this.ClientSize.Width - lbGameOver.Width) / 2,
                (this.ClientSize.Height - lbGameOver.Height) / 2 - 40 
            );

            lbGameOver.BringToFront();

            lbContinue = new Label();
            lbContinue.Font = new Font("Arial", 14, FontStyle.Regular);
            lbContinue.ForeColor = Color.White; 
            lbContinue.AutoSize = true;
            if(colourType != 'Y') lbContinue.Text = "Bạn có muốn chơi tiếp không?";
            pictureBox1.Controls.Add(lbContinue);

            lbContinue.Location = new Point(
                (this.ClientSize.Width - lbContinue.Width) / 2,
                lbGameOver.Bottom + 10 
            );

            lbContinue.BringToFront();

            pictureBox1.Controls.Add(btnNo);

            CreateButtons(lbContinue.Bottom + 20);

            this.StartPosition = FormStartPosition.Manual;
        }

        /// <summary>
        /// Hàm tạo 2 nút YES và NO
        /// </summary>
        private void CreateButtons(int yPosition)
        {
            btnYes = new Button
            {
                Text = "YES",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Location = new Point((this.ClientSize.Width / 2) - 60, yPosition)
            };
            btnYes.Click += BtnYes_Click;
            btnYes.Enter += Btn_Enter;
            btnYes.Leave += Btn_Leave; 
            pictureBox1.Controls.Add(btnYes);

            btnNo = new Button
            {
                Text = "NO",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Location = new Point((this.ClientSize.Width / 2) + 10, yPosition)
            };
            btnNo.Click += BtnNo_Click;
            btnNo.Enter += Btn_Enter; 
            btnNo.Leave += Btn_Leave; 
            pictureBox1.Controls.Add(btnNo);
        }
        private void BtnYes_Click(object sender, EventArgs e)
        {
            playAgain = true;
            this.Close();
        }
        private void BtnNo_Click(object sender, EventArgs e)
        {
            playAgain = false;
            this.Close();
        }
        private void BtnYes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnYes_Click(sender, e);
            }
        }
        private void Btn_Enter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.Blue; 
                btn.ForeColor = Color.White; 
            }
        }
        private void Btn_Leave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.Black; 
                btn.ForeColor = Color.White; 
            }
        }

        /// <summary>
        /// Hàm thực hiện cho form thông báo căn giữa form game đang chạy
        /// </summary>
        /// <param name="parentForm"></param>
        public void CenterToFormRun(Form parentForm)
        {
            this.Location = new Point(parentForm.Location.X + (parentForm.Width - this.Width) / 2, parentForm.Location.Y + (parentForm.Height - this.Height) / 2);
        }
    }
}
