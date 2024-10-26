using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pacman_Game
{
    public partial class GameGuideForm : Form
    {
        // bốn cái option là 4 cái panel
        private Panel option1 = new Panel(); // thông tin các con quái
        private Panel option2 = new Panel(); // theo nội dung
        private Panel option3 = new Panel();
        private Panel option4 = new Panel();
        private List<Panel> options = new List<Panel>();

        //hàm chính để khởi chạy
        public GameGuideForm()
        {
            InitializeComponent();
            ConfigurePanel();
            ConfigurePanel1();
            ConfigurePanel2();
            ConfigurePanel3();
            ConfigurePanel4();
            foreach (var option in options)
            {
                option.Visible = false;
            }

        }
        private void ConfigurePanel()
        {
            for (int i = 0; i < 4; i++)
            {
                Panel panel = new Panel()
                {
                    Size = new Size(300, 350),
                    Location = new Point(this.ClientSize.Width - 310, 50),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.Black
                };
                this.Controls.Add(panel);
                options.Add(panel);

            }
        }
        private void ConfigurePanel1()
        {
            //-----------------------
            //Thông tin Pac-Man
            //-----------------------

            Label labelPacMan = new Label();
            labelPacMan.Text = "Pac-Man";
            labelPacMan.Font = new Font("Arial", 12, FontStyle.Bold);
            labelPacMan.ForeColor = Color.Yellow;
            labelPacMan.Location = new Point(10, 5); 
            labelPacMan.AutoSize = true;
            options[0].Controls.Add(labelPacMan);

            PictureBox pictureBoxPacMan = new PictureBox();
            pictureBoxPacMan.Size = new Size(20, 20);
            pictureBoxPacMan.Location = new Point(labelPacMan.Right + 5, 5);
            pictureBoxPacMan.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPacMan.Image = Properties.Resources.right;
            options[0].Controls.Add(pictureBoxPacMan);

            TextBox txtBoxPacMan = new TextBox();
            txtBoxPacMan.Text = "Nhân vật mà người chơi điều khiển. Rất thích các đồng xu, muốn thu thập tất cả dù phải đối đầu với các bóng ma";
            txtBoxPacMan.Location = new Point(labelPacMan.Left + 5, labelPacMan.Bottom + 5);
            txtBoxPacMan.BackColor = Color.Black;
            txtBoxPacMan.ForeColor = Color.White;
            txtBoxPacMan.Font = new Font("Arial", 11);
            txtBoxPacMan.Size = new Size(280, 60);
            txtBoxPacMan.Multiline = true;
            txtBoxPacMan.BorderStyle = BorderStyle.None;
            options[0].Controls.Add(txtBoxPacMan);

            //-----------------------
            //Thông tin Ma Đỏ
            //-----------------------

            Label labelRedGhost = new Label();
            labelRedGhost.Text = "Ghost màu đỏ";
            labelRedGhost.Font = new Font("Arial", 12, FontStyle.Bold);
            labelRedGhost.ForeColor = Color.Red;
            labelRedGhost.Location = new Point(labelPacMan.Left, txtBoxPacMan.Bottom + 5);
            labelRedGhost.AutoSize = true;
            options[0].Controls.Add(labelRedGhost);

            PictureBox pictureBoxRedGhost = new PictureBox();
            pictureBoxRedGhost.Size = new Size(20, 20);
            pictureBoxRedGhost.Location = new Point(labelRedGhost.Right + 5,txtBoxPacMan.Bottom + 1);
            pictureBoxRedGhost.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRedGhost.Image = Properties.Resources.red_guy;
            options[0].Controls.Add(pictureBoxRedGhost);

            TextBox txtBoxRedGhost = new TextBox();
            txtBoxRedGhost.Text = "Đảm nhận nhiệm vụ ngăn chặn Pac-Man thoát khỏi màn chơi thông qua cánh cổng";
            txtBoxRedGhost.Location = new Point(labelRedGhost.Left + 5, labelRedGhost.Bottom + 5);
            txtBoxRedGhost.BackColor = Color.Black;
            txtBoxRedGhost.ForeColor = Color.White;
            txtBoxRedGhost.Font = new Font("Arial", 11);
            txtBoxRedGhost.Size = new Size(280, 60);
            txtBoxRedGhost.Multiline = true;
            txtBoxRedGhost.BorderStyle = BorderStyle.None;
            options[0].Controls.Add(txtBoxRedGhost);

            //-----------------------
            //Thông tin Ma Vàng
            //-----------------------

            Label labelYellowGhost = new Label();
            labelYellowGhost.Text = "Ghost màu vàng";
            labelYellowGhost.Font = new Font("Arial", 12, FontStyle.Bold);
            labelYellowGhost.ForeColor = Color.Orange;
            labelYellowGhost.Location = new Point(labelRedGhost.Left, txtBoxRedGhost.Bottom + 1); 
            labelYellowGhost.AutoSize = true;
            options[0].Controls.Add(labelYellowGhost);

            PictureBox pictureBoxYellowGhost = new PictureBox();
            pictureBoxYellowGhost.Size = new Size(20, 20);
            pictureBoxYellowGhost.Location = new Point(labelYellowGhost.Right + 5, txtBoxRedGhost.Bottom + 5);
            pictureBoxYellowGhost.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxYellowGhost.Image = Properties.Resources.yellow_guy;
            options[0].Controls.Add(pictureBoxYellowGhost);

            TextBox txtBoxYellowGhost = new TextBox();
            txtBoxYellowGhost.Text = "Đảm nhận nhiệm vụ ngăn chặn Pac-Man vào một trong những phòng chứa nhiều đồng xu";
            txtBoxYellowGhost.Location = new Point(labelRedGhost.Left + 5, labelYellowGhost.Bottom + 5);
            txtBoxYellowGhost.BackColor = Color.Black;
            txtBoxYellowGhost.ForeColor = Color.White;
            txtBoxYellowGhost.Font = new Font("Arial", 11);
            txtBoxYellowGhost.Size = new Size(280, 60);
            txtBoxYellowGhost.Multiline = true;
            txtBoxYellowGhost.BorderStyle = BorderStyle.None;
            options[0].Controls.Add(txtBoxYellowGhost);

            //-----------------------
            //Thông tin Ma Hồng
            //-----------------------

            Label labelPinkGhost = new Label();
            labelPinkGhost.Text = "Ghost màu hồng";
            labelPinkGhost.Font = new Font("Arial", 12, FontStyle.Bold);
            labelPinkGhost.ForeColor = Color.DarkSalmon ;
            labelPinkGhost.Location = new Point(labelYellowGhost.Left, txtBoxYellowGhost.Bottom + 5);
            labelPinkGhost.AutoSize = true;
            options[0].Controls.Add(labelPinkGhost);

            PictureBox pictureBoxPinkGhost = new PictureBox();
            pictureBoxPinkGhost.Size = new Size(20, 20);
            pictureBoxPinkGhost.Location = new Point(labelPinkGhost.Right + 5, txtBoxYellowGhost.Bottom + 5);
            pictureBoxPinkGhost.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPinkGhost.Image = Properties.Resources.pink_guy;
            options[0].Controls.Add(pictureBoxPinkGhost);

            TextBox txtBoxPinkGhost = new TextBox();
            txtBoxPinkGhost.Text = "Đảm nhận nhiệm vụ tiêu diệt Pac-Man, sở hữu lối di chuyển nguy hiểm và khó đoán";
            txtBoxPinkGhost.Location = new Point(labelRedGhost.Left + 5, labelPinkGhost.Bottom + 5);
            txtBoxPinkGhost.BackColor = Color.Black;
            txtBoxPinkGhost.ForeColor = Color.White;
            txtBoxPinkGhost.Font = new Font("Arial", 11);
            txtBoxPinkGhost.Size = new Size(280, 60);
            txtBoxPinkGhost.Multiline = true;
            txtBoxPinkGhost.BorderStyle = BorderStyle.None;
            options[0].Controls.Add(txtBoxPinkGhost);
        }

        private void ConfigurePanel2()
        {
            //-----------------------
            //Di chuyển
            //-----------------------

            Label labelUp = new Label();
            labelUp.Text = "Di chuyển lên";
            labelUp.Font = new Font("Arial", 12, FontStyle.Bold);
            labelUp.ForeColor = Color.Yellow;
            labelUp.Location = new Point(10, 10);
            labelUp.AutoSize = true;
            options[1].Controls.Add(labelUp);

            PictureBox pictureBoxUp = new PictureBox();
            pictureBoxUp.Size = new Size(20, 20);
            pictureBoxUp.Location = new Point(labelUp.Right + 5, 6);
            pictureBoxUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUp.Image = Properties.Resources.AllDirect;
            options[1].Controls.Add(pictureBoxUp);

            TextBox txtBoxUp = new TextBox();
            txtBoxUp.Text = "Ấn nút điều hướng lên";
            txtBoxUp.Location = new Point(labelUp.Left + 5, labelUp.Bottom + 5);
            txtBoxUp.BackColor = Color.Black;
            txtBoxUp.ForeColor = Color.White;
            txtBoxUp.Font = new Font("Arial", 11);
            txtBoxUp.Size = new Size(280, 60);
            txtBoxUp.Multiline = true;
            txtBoxUp.BorderStyle = BorderStyle.None;
            options[1].Controls.Add(txtBoxUp);

        }

        private void ConfigurePanel3()
        {
            //-----------------------
            //Cách chiến thắng
            //-----------------------

            Label labelWin = new Label();
            labelWin.Text = "Cách chiến thắng";
            labelWin.Font = new Font("Arial", 12, FontStyle.Bold);
            labelWin.ForeColor = Color.Yellow;
            labelWin.Location = new Point(10, 10);
            labelWin.AutoSize = true;
            options[2].Controls.Add(labelWin);

            PictureBox pictureBoxWin = new PictureBox();
            pictureBoxWin.Size = new Size(20, 20);
            pictureBoxWin.Location = new Point(labelWin.Right + 5, 5);
            pictureBoxWin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWin.Image = Properties.Resources.coin;
            options[2].Controls.Add(pictureBoxWin);

            TextBox txtBoxWin = new TextBox();
            txtBoxWin.Text = "Có tổng cộng 31 đồng xu (coins) nhỏ rải rác khắp map tương ứng với 1 điểm và 3 đồng xu to tương ứng với 5 điểm được canh giữ bởi các Ghost. Mục tiêu của người chơi là kiếm đủ 31 điểm hoặc thu thập hết xu nhỏ để có thể chiến thắng";
            txtBoxWin.Location = new Point(labelWin.Left + 5, labelWin.Bottom + 5);
            txtBoxWin.BackColor = Color.Black;
            txtBoxWin.ForeColor = Color.White;
            txtBoxWin.Font = new Font("Arial", 11);
            txtBoxWin.Size = new Size(280, 150);
            txtBoxWin.Multiline = true;
            txtBoxWin.BorderStyle = BorderStyle.None;
            options[2].Controls.Add(txtBoxWin);
        }

        private void ConfigurePanel4()
        {
            //-----------------------
            //Chế độ Tân binh
            //-----------------------

            Label labelBeginner = new Label();
            labelBeginner.Text = "Chế độ Tân binh";
            labelBeginner.Font = new Font("Arial", 12, FontStyle.Bold);
            labelBeginner.ForeColor = Color.Yellow;
            labelBeginner.Location = new Point(10, 10);
            labelBeginner.AutoSize = true;
            options[3].Controls.Add(labelBeginner);

            //PictureBox pictureBoxBeginner = new PictureBox();
            //pictureBoxBeginner.Size = new Size(20, 20);
            //pictureBoxBeginner.Location = new Point(labelBeginner.Right + 2, 9);
            //pictureBoxBeginner.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBoxBeginner.Image = Properties.Resources.heart;
            //options[3].Controls.Add(pictureBoxBeginner);

            TextBox txtBoxBeginner = new TextBox();
            txtBoxBeginner.Text = "Chế độ Tân binh sẽ mang đến trải nghiệm thu thập đồng xu cơ bản, giúp người chơi làm quen với mọi điều trong game. Không có gì phải vội – hãy cẩn thận né tránh các Ghost và thu thập đồng xu để hoàn thành thử thách";
            txtBoxBeginner.Location = new Point(labelBeginner.Left + 5, labelBeginner.Bottom + 5);
            txtBoxBeginner.BackColor = Color.Black;
            txtBoxBeginner.ForeColor = Color.White;
            txtBoxBeginner.Font = new Font("Arial", 11);
            txtBoxBeginner.Size = new Size(280, 120);
            txtBoxBeginner.Multiline = true;
            txtBoxBeginner.BorderStyle = BorderStyle.None;
            options[3].Controls.Add(txtBoxBeginner);

            Label labelExpert = new Label();
            labelExpert.Text = "Chế độ Cao thủ";
            labelExpert.Font = new Font("Arial", 12, FontStyle.Bold);
            labelExpert.ForeColor = Color.Yellow;
            labelExpert.Location = new Point(10, txtBoxBeginner.Bottom + 5);
            labelExpert.AutoSize = true;
            options[3].Controls.Add(labelExpert);

            //PictureBox pictureBoxExpert = new PictureBox();
            //pictureBoxExpert.Size = new Size(20, 20);
            //pictureBoxExpert.Location = new Point(labelExpert.Right + 2, txtBoxBeginner.Bottom + 9);
            //pictureBoxExpert.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBoxExpert.Image = Properties.Resources.skull;
            //options[3].Controls.Add(pictureBoxExpert);

            TextBox txtBoxExpert = new TextBox();
            txtBoxExpert.Text = "Chế độ Thử thách sẽ mở ra khi người chơi hoàn thành Chế độ Tân binh! Mọi thứ diễn ra bình thường cho đến khi người chơi đạt 25 điểm. Từ đó, các chướng ngại vật sẽ bắt đầu di chuyển, gây khó khăn cho người chơi trong hành trình thu thập các đồng xu";
            txtBoxExpert.Location = new Point(labelExpert.Left + 5, labelExpert.Bottom + 5);
            txtBoxExpert.BackColor = Color.Black;
            txtBoxExpert.ForeColor = Color.White;
            txtBoxExpert.Font = new Font("Arial", 11);
            txtBoxExpert.Size = new Size(280, 120);
            txtBoxExpert.Multiline = true;
            txtBoxExpert.BorderStyle = BorderStyle.None;
            options[3].Controls.Add(txtBoxExpert);
        }

        private void showOption(Panel optionType)
        {
            foreach (var option in options)
            {
                option.Visible = false;
            }

            optionType.Visible = true;
        }

        private void CharInfor_Click(object sender, EventArgs e)
        {
            showOption(options[0]);
        }

        private void HowToPlay_Click(object sender, EventArgs e)
        {
            showOption(options[1]);
        }

        private void HowToWin_Click(object sender, EventArgs e)
        {
            showOption(options[2]);
        }

        private void Mode_Click(object sender, EventArgs e)
        {
            showOption(options[3]);
        }

    }
}
