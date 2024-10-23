using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_Game
{
    public partial class GameStartForm : Form
    {
        private int gameLevel;

        public GameStartForm()
        {
            InitializeComponent();
        }
        private void btnTanBinh(object sender, EventArgs e)
        {
            gameLevel = 0;
            StartGame();
        }

        private void btnCaoThu(object sender, EventArgs e)
        {
            gameLevel = 1;
            StartGame();
        }

        /// <summary>
        /// Hàm thực hiện kiểm tra người dùng chọn chế độ game là gì để khởi chạy theo chế độ đó
        /// </summary>
        private void StartGame()
        {
            this.Hide();

            GameRunForm gameRunForm = new GameRunForm();
            gameRunForm.levelGame = gameLevel; 
            gameRunForm.FocusToFormStart(this);
            gameRunForm.ShowDialog(); 
            
            this.Show(); 
        }
 

    }


}
