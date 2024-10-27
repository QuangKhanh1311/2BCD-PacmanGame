using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pacman_Game
{
    public partial class GameGuideForm : Form
    {
        private Panel option1 = new Panel(); 
        private Panel option2 = new Panel(); 
        private Panel option3 = new Panel();
        private Panel option4 = new Panel();
        private List<Panel> options = new List<Panel>();

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

        //-----------------------
        //Thông tin các nhân vật
        //-----------------------
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
            txtBoxPacMan.ReadOnly = true;
            options[0].Controls.Add(txtBoxPacMan);

            //-----------------------
            //Thông tin Ma Đỏ
            //-----------------------

            Label labelRedGhost = new Label();
            labelRedGhost.Text = "Ghost màu đỏ";
            labelRedGhost.Font = new Font("Arial", 12, FontStyle.Bold);
            labelRedGhost.ForeColor = Color.Red;
            labelRedGhost.Location = new Point(labelPacMan.Left, txtBoxPacMan.Bottom + 8);
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
            txtBoxRedGhost.Size = new Size(280, 50);
            txtBoxRedGhost.Multiline = true;
            txtBoxRedGhost.BorderStyle = BorderStyle.None;
            txtBoxRedGhost.ReadOnly = true;
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
            txtBoxYellowGhost.ReadOnly = true;
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
            txtBoxPinkGhost.ReadOnly = true;
            options[0].Controls.Add(txtBoxPinkGhost);
        }

        //-----------------------
        //Cách chơi và các item
        //-----------------------
        private void ConfigurePanel2()
        {
            //-----------------------
            //Di chuyển
            //-----------------------

            Label labelMove = new Label();
            labelMove.Text = "Di chuyển";
            labelMove.Font = new Font("Arial", 12, FontStyle.Bold);
            labelMove.ForeColor = Color.Yellow;
            labelMove.Location = new Point(10, 10);
            labelMove.AutoSize = true;
            options[1].Controls.Add(labelMove);

            PictureBox pictureBoxMove = new PictureBox();
            pictureBoxMove.Size = new Size(20, 20);
            pictureBoxMove.Location = new Point(labelMove.Right + 5, 6);
            pictureBoxMove.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMove.Image = Properties.Resources.AllDirect;
            options[1].Controls.Add(pictureBoxMove);

            RichTextBox txtBoxMove = new RichTextBox();
            txtBoxMove.Text = "Ấn các nút điều hướng như lên: ⬆, xuống: ⬇, trái: ⬅, phải: ⮕ để di chuyển Pac-Man tới hướng mong muốn";
            txtBoxMove.Location = new Point(labelMove.Left + 5, labelMove.Bottom + 5);
            txtBoxMove.BackColor = Color.Black;
            txtBoxMove.ForeColor = Color.White;
            txtBoxMove.Font = new Font("Arial", 11);
            txtBoxMove.Size = new Size(280, 70);
            txtBoxMove.BorderStyle = BorderStyle.None;
            txtBoxMove.ReadOnly = true;
            txtBoxMove.Multiline = true;
            txtBoxMove.ScrollBars = RichTextBoxScrollBars.None;

            // Thiết lập khoảng cách dòng
            txtBoxMove.SelectionStart = 0;
            txtBoxMove.SelectionLength = txtBoxMove.Text.Length;
            txtBoxMove.SelectionCharOffset = 5;

            options[1].Controls.Add(txtBoxMove);


            //-----------------------
            //Item đóng băng
            //-----------------------
            Label labelFreeze = new Label();
            labelFreeze.Text = "Vật phẩm đóng băng";
            labelFreeze.Font = new Font("Arial", 12, FontStyle.Bold);
            labelFreeze.ForeColor = Color.Aqua;
            labelFreeze.Location = new Point(10, txtBoxMove.Bottom + 22);
            labelFreeze.AutoSize = true;
            options[1].Controls.Add(labelFreeze);

            PictureBox pictureBoxFreeze = new PictureBox();
            pictureBoxFreeze.Size = new Size(20, 20);
            pictureBoxFreeze.Location = new Point(labelFreeze.Right + 5, txtBoxMove.Bottom + 5);
            pictureBoxFreeze.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFreeze.Image = Properties.Resources.ice;
            options[1].Controls.Add(pictureBoxFreeze);

            RichTextBox txtBoxFreeze = new RichTextBox();
            txtBoxFreeze.Text = "Sau khi thu thập sẽ khiến các Ghost bị đóng băng (bất động) trong vòng 3 giây";
            txtBoxFreeze.Location = new Point(labelFreeze.Left + 5, labelFreeze.Bottom + 5);
            txtBoxFreeze.BackColor = Color.Black;
            txtBoxFreeze.ForeColor = Color.White;
            txtBoxFreeze.Font = new Font("Arial", 11);
            txtBoxFreeze.Size = new Size(280, 60);
            txtBoxFreeze.BorderStyle = BorderStyle.None;
            txtBoxFreeze.ReadOnly = true;
            txtBoxFreeze.Multiline = true;
            txtBoxFreeze.ScrollBars = RichTextBoxScrollBars.None;

            // Thiết lập khoảng cách dòng
            txtBoxFreeze.SelectionStart = 0;
            txtBoxFreeze.SelectionLength = txtBoxFreeze.Text.Length;
            txtBoxFreeze.SelectionCharOffset = 5;

            options[1].Controls.Add(txtBoxFreeze);


            //-----------------------
            //Item bất tử
            //-----------------------

            Label labelImmor = new Label();
            labelImmor.Text = "Vật phẩm bất tử";
            labelImmor.Font = new Font("Arial", 12, FontStyle.Bold);
            labelImmor.ForeColor = Color.Aquamarine;
            labelImmor.Location = new Point(10, txtBoxFreeze.Bottom + 10);
            labelImmor.AutoSize = true;
            options[1].Controls.Add(labelImmor);

            PictureBox pictureBoxImmor = new PictureBox();
            pictureBoxImmor.Size = new Size(20, 20);
            pictureBoxImmor.Location = new Point(labelImmor.Right + 5, txtBoxFreeze.Bottom + 5);
            pictureBoxImmor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImmor.Image = Properties.Resources.immortal;
            options[1].Controls.Add(pictureBoxImmor);

            RichTextBox txtBoxImmor = new RichTextBox();
            txtBoxImmor.Text = "Sau khi thu thập sẽ khiến nhân vật Pac-Man của người chơi bất khả xâm phạm trong vòng 3 giây";
            txtBoxImmor.Location = new Point(labelImmor.Left + 5, labelImmor.Bottom + 5);
            txtBoxImmor.BackColor = Color.Black;
            txtBoxImmor.ForeColor = Color.White;
            txtBoxImmor.Font = new Font("Arial", 11);
            txtBoxImmor.Size = new Size(280, 70);
            txtBoxImmor.BorderStyle = BorderStyle.None;
            txtBoxImmor.ReadOnly = true;
            txtBoxImmor.Multiline = true;
            txtBoxImmor.ScrollBars = RichTextBoxScrollBars.None;

            // Thiết lập khoảng cách dòng
            txtBoxImmor.SelectionStart = 0;
            txtBoxImmor.SelectionLength = txtBoxImmor.Text.Length;
            txtBoxImmor.SelectionCharOffset = 5;
            
            options[1].Controls.Add(txtBoxImmor);

        }

        //-----------------------
        //Cách chiến thắng
        //-----------------------
        private void ConfigurePanel3()
        {
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

            RichTextBox txtBoxWin = new RichTextBox();
            txtBoxWin.Text = "Có tổng cộng 31 đồng xu (coins) nhỏ rải rác khắp map tương ứng với 1 điểm và 3 đồng xu to tương ứng với 5 điểm được canh giữ bởi các Ghost. Mục tiêu của người chơi là kiếm đủ 31 điểm hoặc thu thập hết xu nhỏ để có thể chiến thắng";
            txtBoxWin.Location = new Point(labelWin.Left + 5, labelWin.Bottom + 5);
            txtBoxWin.BackColor = Color.Black;
            txtBoxWin.ForeColor = Color.White;
            txtBoxWin.Font = new Font("Arial", 11);
            txtBoxWin.Size = new Size(280, 150);
            txtBoxWin.BorderStyle = BorderStyle.None;
            txtBoxWin.ReadOnly = true;
            txtBoxWin.Multiline = true;
            txtBoxWin.ScrollBars = RichTextBoxScrollBars.None;
            txtBoxWin.Padding = new Padding(5);

            // Thiết lập khoảng cách dòng
            txtBoxWin.SelectionStart = 0;
            txtBoxWin.SelectionLength = txtBoxWin.Text.Length;
            txtBoxWin.SelectionCharOffset = 5;
            
            options[2].Controls.Add(txtBoxWin);

        }

        //-----------------------
        //Các chế độ chơi
        //-----------------------
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

            RichTextBox txtBoxBeginner = new RichTextBox();
            txtBoxBeginner.Text = "Chế độ Thử thách sẽ mở ra khi người chơi hoàn thành Chế độ Tân binh! Mọi thứ diễn ra bình thường cho đến khi người chơi đạt 25 điểm. Từ đó, các chướng ngại vật sẽ bắt đầu di chuyển, gây khó khăn cho người chơi trong hành trình thu thập các đồng xu";
            txtBoxBeginner.Location = new Point(labelBeginner.Left + 5, labelBeginner.Bottom + 5);
            txtBoxBeginner.BackColor = Color.Black;
            txtBoxBeginner.ForeColor = Color.White;
            txtBoxBeginner.Font = new Font("Arial", 11);
            txtBoxBeginner.Size = new Size(280, 150);
            txtBoxBeginner.BorderStyle = BorderStyle.None;
            txtBoxBeginner.ReadOnly = true;
            txtBoxBeginner.Multiline = true;
            txtBoxBeginner.ScrollBars = RichTextBoxScrollBars.None;
            txtBoxBeginner.Padding = new Padding(5);

            // Thiết lập khoảng cách dòng
            txtBoxBeginner.SelectionStart = 0;
            txtBoxBeginner.SelectionLength = txtBoxBeginner.Text.Length;
            txtBoxBeginner.SelectionCharOffset = 3;

            options[3].Controls.Add(txtBoxBeginner);

            //-----------------------
            //Chế độ Cao thủ
            //-----------------------

            Label labelExpert = new Label();
            labelExpert.Text = "Chế độ Cao thủ";
            labelExpert.Font = new Font("Arial", 12, FontStyle.Bold);
            labelExpert.ForeColor = Color.Yellow;
            labelExpert.Location = new Point(10, txtBoxBeginner.Bottom + 3);
            labelExpert.AutoSize = true;
            options[3].Controls.Add(labelExpert);

            RichTextBox txtBoxExpert = new RichTextBox();
            txtBoxExpert.Text = "Chế độ Thử thách sẽ mở ra khi người chơi hoàn thành Chế độ Tân binh! Mọi thứ diễn ra bình thường cho đến khi người chơi đạt 25 điểm. Từ đó, các chướng ngại vật sẽ bắt đầu di chuyển, gây khó khăn cho người chơi trong hành trình thu thập các đồng xu";
            txtBoxExpert.Location = new Point(labelExpert.Left + 5, labelExpert.Bottom + 5);
            txtBoxExpert.BackColor = Color.Black;
            txtBoxExpert.ForeColor = Color.White;
            txtBoxExpert.Font = new Font("Arial", 11);
            txtBoxExpert.Size = new Size(280, 150);
            txtBoxExpert.BorderStyle = BorderStyle.None;
            txtBoxExpert.ReadOnly = true;
            txtBoxExpert.Multiline = true;
            txtBoxExpert.ScrollBars = RichTextBoxScrollBars.None;
            txtBoxExpert.Padding = new Padding(5);

            // Thiết lập khoảng cách dòng
            txtBoxExpert.SelectionStart = 0;
            txtBoxExpert.SelectionLength = txtBoxExpert.Text.Length;
            txtBoxExpert.SelectionCharOffset = 3;

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
            CharInfor.BackColor = Color.Black;
            HowToPlay.BackColor = Color.Black;
            HowToWin.BackColor = Color.Black;
            Mode.BackColor = Color.Black;

            CharInfor.BackColor = Color.Gray;
            showOption(options[0]);
        }

        private void HowToPlay_Click(object sender, EventArgs e)
        {
            CharInfor.BackColor = Color.Black;
            HowToPlay.BackColor = Color.Black;
            HowToWin.BackColor = Color.Black;
            Mode.BackColor = Color.Black;

            HowToPlay.BackColor = Color.Gray;
            showOption(options[1]);
        }

        private void HowToWin_Click(object sender, EventArgs e)
        {
            CharInfor.BackColor = Color.Black;
            HowToPlay.BackColor = Color.Black;
            HowToWin.BackColor = Color.Black;
            Mode.BackColor = Color.Black;

            HowToWin.BackColor = Color.Gray;
            showOption(options[2]);
        }

        private void Mode_Click(object sender, EventArgs e)
        {
            CharInfor.BackColor = Color.Black;
            HowToPlay.BackColor = Color.Black;
            HowToWin.BackColor = Color.Black;
            Mode.BackColor = Color.Black;

            Mode.BackColor = Color.Gray;
            showOption(options[3]);
        }

    }
}
