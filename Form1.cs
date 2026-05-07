using System.Security.Cryptography;
using XOGame.Properties;

namespace XOGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enPlayer { Player1, PLayer2 }

        enPlayer PlayerTurn;

        enum enWinner { Player1, Player2, Draw, InProgrees }


        struct stGameStauts
        {
            public bool GameOver;
            public short PlayCount;
            public enWinner Winner;
        }

        stGameStauts GameStauts;


        bool CheakValue(PictureBox pit1, PictureBox pit2, PictureBox pit3)
        {
            if (pit1.Tag.ToString() != "?" && pit1.Tag.ToString() == pit2.Tag.ToString()
                && pit1.Tag.ToString() == pit3.Tag.ToString())
            {
                pit1.BackColor = Color.Green;
                pit2.BackColor = Color.Green;
                pit3.BackColor = Color.Green;
                if (pit1.Tag.ToString() == "X")
                {
                    laWinner.Text = "Player1";
                    GameStauts.GameOver = true;
                    GameStauts.Winner = enWinner.Player1;
                    MessageBox.Show("Player1 Winner", "Winner", MessageBoxButtons.OK);
                    EndGame();
                }
                else
                {
                    laWinner.Text = "Player2";
                    GameStauts.GameOver = true;
                    GameStauts.Winner = enWinner.Player2;
                    MessageBox.Show("Player2 Winner", "Winner", MessageBoxButtons.OK);
                    EndGame();
                }
            }
            return false;
        }

        void CheakWinner()
        {
            if (CheakValue(pictureBox2, pictureBox3, pictureBox4))
                return;
            if (CheakValue(pictureBox5, pictureBox6, pictureBox7))
                return;
            if (CheakValue(pictureBox13, pictureBox11, pictureBox12))
                return;
            if (CheakValue(pictureBox2, pictureBox5, pictureBox13))
                return;
            if (CheakValue(pictureBox3, pictureBox6, pictureBox12))
                return;
            if (CheakValue(pictureBox4, pictureBox7, pictureBox11))
                return;
            if (CheakValue(pictureBox4, pictureBox6, pictureBox13))
                return;
            if (CheakValue(pictureBox2, pictureBox6, pictureBox11))
                return;

        }

        void EndGame()
        {
            laTurn.Text = "Game Over";

            switch (GameStauts.Winner)
            {
                case enWinner.Player1:
                    laWinner.Text = "Player1";
                    break;
                case enWinner.Player2:
                    laWinner.Text = "Player2";
                    break;
                default:

                    laWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RestartGame();
        }


        void ChangeImage(PictureBox btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Tag = "X";
                        btn.Image = Resources.X;
                        laTurn.Text = "Player2";
                        PlayerTurn = enPlayer.PLayer2;
                        GameStauts.PlayCount++;
                        CheakWinner();
                        break;
                    case enPlayer.PLayer2:
                        btn.Tag = "O";
                        btn.Image = Resources.O;
                        laTurn.Text = "Player1";
                        PlayerTurn = enPlayer.Player1;
                        GameStauts.PlayCount++;
                        CheakWinner();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Error,This Selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStauts.PlayCount == 9)
            {
                GameStauts.GameOver = true;
                laWinner.Text = "Draw";
                MessageBox.Show("Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        void ResatButton(PictureBox Pit)
        {
            Pit.Tag = "?";
            Pit.Image = Resources.question_mark_96;
            Pit.BackColor = Color.Transparent;
        }

        void RestartGame()
        {
            ResatButton(pictureBox2);
            ResatButton(pictureBox3);
            ResatButton(pictureBox4);
            ResatButton(pictureBox5);
            ResatButton(pictureBox6);
            ResatButton(pictureBox7);
            ResatButton(pictureBox11);
            ResatButton(pictureBox12);
            ResatButton(pictureBox13);

            laTurn.Text = "Player1";
            GameStauts.GameOver = false;
            GameStauts.Winner = enWinner.InProgrees;
            GameStauts.PlayCount = 0;
            PlayerTurn = enPlayer.Player1;
            laWinner.Text = "In Progrees";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 15;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(whitePen, 250, 75, 815, 75);
            e.Graphics.DrawLine(whitePen, 250, 74, 250, 450);
            e.Graphics.DrawLine(whitePen, 814, 75, 814, 450);
            e.Graphics.DrawLine(whitePen, 250, 450, 815, 450);


            e.Graphics.DrawLine(whitePen, 420, 75, 420, 445);
            e.Graphics.DrawLine(whitePen, 615, 75, 615, 445);


            e.Graphics.DrawLine(whitePen, 250, 185, 815, 185);
            e.Graphics.DrawLine(whitePen, 250, 310, 815, 310);




        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X: {e.X} Y: {e.Y}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChangeImage(pictureBox3);
        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChangeImage(pictureBox2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ChangeImage(pictureBox4);
        }



        private void pictureBox13_Click(object sender, EventArgs e)
        {
            ChangeImage(pictureBox13);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ChangeImage(pictureBox12);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ChangeImage(pictureBox11);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeImage(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ChangeImage(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ChangeImage(pictureBox7);
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
