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
    public partial class GameRunForm : Form
    {
        private  Point redGhostDefaultPosition;
        private  Point yellowGhostDefaultPosition;
        private  Point pinkGhostDefaultPosition;
        private Point[] wallDefaultPositions;
        private char colourType;
        private int totalCoins = 31;
        public int levelGame;

        bool goUp, goDown, goLeft, goRight, isGameOver;
        int playerScore, playerSpeed, redGhostSpeed, yellowGhostSpeed, 
            pinkGhostX, pinkGhostY,wallTop1Speed,wallTop2Speed,wallBottom1Speed, wallBottom2Speed;

        public GameRunForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //----------------------------
            // Thiết lập tọa độ mặc định cho các ghost
            //----------------------------
            redGhostDefaultPosition = new Point(redGhost.Left, redGhost.Top);
            yellowGhostDefaultPosition = new Point(yellowGhost.Left, yellowGhost.Top);
            pinkGhostDefaultPosition = new Point(pinkGhost.Left, pinkGhost.Top);

            //----------------------------
            // Thiết lập tọa độ mặc định cho các wall
            //----------------------------
            wallDefaultPositions = new Point[4];

            wallDefaultPositions[0] = new Point(wallTop1.Left, wallTop1.Top);
            wallDefaultPositions[1] = new Point(wallTop2.Left, wallTop2.Top);
            wallDefaultPositions[2] = new Point(wallBottom1.Left, wallBottom1.Top);
            wallDefaultPositions[3] = new Point(wallBottom2.Left, wallBottom2.Top);

            ResetGame();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainGameTimer(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + playerScore;

            //----------------------s------
            // Điều hướng pacman
            //----------------------------
            if (goLeft)
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.left;
            }
            if (goRight)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.right;
            }
            if (goUp)
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.Up;
            }
            if (goDown)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.down;
            }

            if (pacman.Left < -10) 
                pacman.Left = this.ClientSize.Width;
            if (pacman.Left > this.ClientSize.Width) 
                pacman.Left = -10;
            if (pacman.Top < -10) 
                pacman.Top = this.ClientSize.Height;
            if (pacman.Top > this.ClientSize.Height) 
                pacman.Top = -10;

            //----------------------------
            // Kiểm tra các va chạm giữa pacman và đối tượng khác
            //----------------------------
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if ((string)x.Tag == "coin" && x.Visible == true)
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                            playerScore += 1;
                        }

                    if ((string)x.Tag == "bigcoin" && x.Visible == true)
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                            playerScore += 5;
                        }

                    if ((string)x.Tag == "wall")
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                            GameOver("You lose!" , 'R');

                    if ((string)x.Tag == "ghost")
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                            GameOver("You lose!", 'R');
                }
                    
            }

            MoveGhosts();

            if (playerScore >= totalCoins) 
                GameOver("You win!",'G');
        }

        /// <summary>
        /// Hàm thực hiện nhận biết phím được nhả
        /// </summary>
        private void Pacman_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) goUp = false;
            if (e.KeyCode == Keys.Down) goDown = false;
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
        }

        /// <summary>
        /// Hàm thực hiện nhận biết phím được nhấn
        /// </summary>
        private void Pacman_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) goUp = true;
            if (e.KeyCode == Keys.Down) goDown = true;
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
        }
       
       /// <summary>
       /// Hàm thực hiện di chuyển các ghost có trong gamne
       /// </summary>
        private void MoveGhosts()
        {
            //----------------------------
            // Di chuyển red ghost
            //----------------------------
            redGhost.Top += redGhostSpeed;

            if (redGhost.Bounds.IntersectsWith(wallBottom2.Bounds) || redGhost.Top == 0)
                redGhostSpeed = -redGhostSpeed;

            //----------------------------
            // Di chuyển yellow ghost
            //----------------------------
            yellowGhost.Left -= yellowGhostSpeed;

            if (yellowGhost.Bounds.IntersectsWith(wallBottom1.Bounds) || yellowGhost.Bounds.IntersectsWith(wallBottom2.Bounds))
                yellowGhostSpeed = -yellowGhostSpeed;

            //----------------------------
            // Di chuyển pink ghost
            //----------------------------
            pinkGhost.Left += pinkGhostX;
            pinkGhost.Top += pinkGhostY;

            if (pinkGhost.Left < 0 || pinkGhost.Left > this.ClientSize.Width - pinkGhost.Width || pinkGhost.Bounds.IntersectsWith(txtScore.Bounds))
                pinkGhostX = -pinkGhostX;

            if (pinkGhost.Top < 0 || pinkGhost.Top > this.ClientSize.Height - pinkGhost.Height || pinkGhost.Bounds.IntersectsWith(txtScore.Bounds))
                pinkGhostY = -pinkGhostY;

            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "wall")
                {
                    if (pinkGhost.Bounds.IntersectsWith(x.Bounds))
                    {

                        float distanceLeft = Math.Abs(pinkGhost.Left - x.Right);
                        float distanceRight = Math.Abs(pinkGhost.Right - x.Left);
                        float distanceTop = Math.Abs(pinkGhost.Top - x.Bottom);
                        float distanceBottom = Math.Abs(pinkGhost.Bottom - x.Top);

                        float minDistance = Math.Min(Math.Min(distanceLeft, distanceRight), Math.Min(distanceTop, distanceBottom));

                        if (minDistance == distanceLeft)
                        {
                            pinkGhostX = -pinkGhostX; 
                            pinkGhost.Left = x.Right; 
                        }
                        else if (minDistance == distanceRight)
                        {
                            pinkGhostX = -pinkGhostX;
                            pinkGhost.Left = x.Left - pinkGhost.Width;
                        }
                        else if (minDistance == distanceTop)
                        {
                            pinkGhostY = -pinkGhostY; 
                            pinkGhost.Top = x.Bottom; 
                        }
                        else if (minDistance == distanceBottom)
                        {
                            pinkGhostY = -pinkGhostY;
                            pinkGhost.Top = x.Top - pinkGhost.Height;
                        }
                        break;
                    }
                }
            }

            //----------------------------
            // Thực hiện cho các tường di chuyển
            //----------------------------
            if (levelGame == 1)
            {
                wallTop1.Left -= wallTop1Speed;
                if (wallTop1.Left <= 10 || wallTop1.Left > this.ClientSize.Width / 2)
                    wallTop1Speed = -wallTop1Speed;
                wallTop2.Top += wallTop2Speed;
                if (wallTop2.Top > this.ClientSize.Height / 2 || wallTop2.Top < -25)
                    wallTop2Speed = -wallTop2Speed;
                if (playerScore > 25)
                {
                    wallBottom1.Top += wallBottom1Speed;
                    if (wallBottom1.Top <= this.ClientSize.Height / 2 + 10 || wallBottom1.Top > this.ClientSize.Width + 25)
                        wallBottom1Speed = -wallBottom1Speed;

                    wallBottom2.Left += wallBottom2Speed;
                    if (wallBottom2.Left <= this.ClientSize.Width / 2 || wallBottom2.Left > this.ClientSize.Width - 25)
                        wallBottom2Speed = -wallBottom2Speed;
                }
            }


        }

        /// <summary>
        /// Hàm thực hiện Reset game khi người chơi muốn chơi tiếp
        /// </summary>
        private void ResetGame()
        {
            txtScore.Text = "Score: 0";
            playerScore = 0;

            wallTop1.Location = wallDefaultPositions[0];
            wallTop2.Location = wallDefaultPositions[1];
            wallBottom1.Location = wallDefaultPositions[2];
            wallBottom2.Location = wallDefaultPositions[3];

            playerSpeed = 5;
            redGhostSpeed = 5;
            yellowGhostSpeed =5;
            pinkGhostX = 2;
            pinkGhostY = 2;

            if(levelGame == 0) 
            {
                wallTop1Speed = 0;
                wallTop2Speed = 0;
                wallBottom1Speed = 0;
                wallBottom2Speed = 0;
            }
            else if(levelGame == 1)
            {
                gateMap.Visible = false;
                wallTop1.Left += 15;
                wallTop1Speed = 2;
                wallTop2Speed = 2;
                wallBottom1Speed = 2;
                wallBottom2Speed = 2;
            }

            goUp = goDown = goLeft = goRight = false;
            isGameOver = false;

            pacman.Left = 31;
            pacman.Top = 46;

            redGhost.Location = redGhostDefaultPosition;
            yellowGhost.Location = yellowGhostDefaultPosition;
            pinkGhost.Location = pinkGhostDefaultPosition;
           
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                    x.Visible = true;
            }

            gameTimer.Start();
        }
        /// <summary>
        /// Hàm xử lý khi người chơi thắng và thua
        /// </summary>
        /// <param name="gameMessage"></param>
        /// <param name="colourType"></param>
        private void GameOver(string gameMessage, char colourType)
        {
            isGameOver = true;

            gameTimer.Stop();

            GameOverForm gameOverForm = new GameOverForm();
            gameOverForm.ShowGameOver(gameMessage,colourType);
            gameOverForm.CenterToFormRun(this);
            gameOverForm.ShowDialog();
            
            if (gameOverForm.playAgain)
                ResetGame(); 
            else
                Close(); 
               
        }
        /// <summary>
        /// Hàm thực hiện xuất hiện form game cùng vị trí với form menu
        /// </summary>
        /// <param name="parentForm"></param>
        public void FocusToFormStart(Form parentForm)
        {
            this.Location = new Point(parentForm.Location.X, parentForm.Location.Y);
        }
    }
   
}
