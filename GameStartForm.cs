using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_Game
{
    public partial class GameStartForm : Form
    {
        private int gameLevel;
        private SoundPlayer gameSound;
        public GameStartForm()
        {
            InitializeComponent();
            gameSound = new SoundPlayer(Properties.Resources.gameSound);
            gameSound.PlayLooping();
        }

        /// <summary>
        /// Hàm thực hiện kiểm tra người dùng chọn chế độ game là gì để khởi chạy theo chế độ đó
        /// </summary>
        private void StartGame(int CheckMap)
        {
            this.Hide();

            GameRunForm gameRunForm = new GameRunForm();
            gameRunForm.levelGame = gameLevel; 
            gameRunForm.FocusToFormStart(this);

            gameRunForm.ShowDialog();

            this.Show();
            gameSound.PlayLooping();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            GameGuideForm gameGuideForm = new GameGuideForm();
            gameGuideForm.FocusToFormStart(this);
            gameGuideForm.ShowDialog();

            this.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            gameLevel = 1;
            gameSound.Stop();
            StartGame(1);
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            gameLevel = 0;
            gameSound.Stop();
            StartGame(0);
        }

    }


}
