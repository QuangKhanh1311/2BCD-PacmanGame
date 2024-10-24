using System;
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

        public GameGuideForm()
        {
            InitializeComponent();
            ConfigurePanel1();
            ConfigurePanel2();
            option1.Visible = false;
            option2.Visible = false;
            option3.Visible = false;
            option4.Visible = false;

        }

        private void ConfigurePanel1()
        {
            option1.Size = new Size(300, 350);
            option1.Location = new Point(this.ClientSize.Width - option1.Width - 10, 50);
            option1.BorderStyle = BorderStyle.FixedSingle;
            option1.BackColor = Color.Black;
            option1.BringToFront();
            this.Controls.Add(option1);

            Label label = new Label();
            label.Text = "Ghost màu đỏ";
            label.Font = new Font("Arial", 12, FontStyle.Bold);
            label.ForeColor = Color.Red;
            label.Location = new Point(10, 10);
            label.AutoSize = true;
            option1.Controls.Add(label);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(20, 20);
            pictureBox.Location = new Point(label.Right + 5, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = Properties.Resources.red_guy;
            option1.Controls.Add(pictureBox);

            TextBox txtbox = new TextBox();
            txtbox.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            txtbox.Location = new Point(label.Left + 5, label.Bottom + 5);
            txtbox.BackColor = Color.Black;
            txtbox.ForeColor = Color.White;
            txtbox.Font = new Font("Arial", 11);
            txtbox.Size = new Size(280, 60);
            txtbox.Multiline = true;
            txtbox.BorderStyle = BorderStyle.None;
            option1.Controls.Add(txtbox);
        }

        private void ConfigurePanel2()
        {
            option2.Size = new Size(300, 350);
            option2.Location = new Point(this.ClientSize.Width - option2.Width - 10, 50);
            option2.BorderStyle = BorderStyle.FixedSingle;
            option2.BackColor = Color.Gray; // Màu nền khác để phân biệt
            option2.BringToFront();
            this.Controls.Add(option2);

            Label label = new Label();
            label.Text = "Ghost màu xanh";
            label.Font = new Font("Arial", 12, FontStyle.Bold);
            label.ForeColor = Color.Blue;
            label.Location = new Point(10, 10);
            label.AutoSize = true;
            option2.Controls.Add(label);

            // Thêm các thành phần khác cho option2 như PictureBox, TextBox...
        }


        private void showOption(Panel optionType)
        {
            option1.Visible = false;
            option2.Visible = false;
            option3.Visible = false;
            option4.Visible = false;

            optionType.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showOption(option1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showOption(option2);
        }
    }
}
