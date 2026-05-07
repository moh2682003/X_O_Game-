namespace XOGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            laTurn = new Label();
            laWinner = new Label();
            btRestart = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(22, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(63, 153);
            label1.Name = "label1";
            label1.Size = new Size(94, 35);
            label1.TabIndex = 1;
            label1.Text = "Turn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(42, 236);
            label2.Name = "label2";
            label2.Size = new Size(135, 35);
            label2.TabIndex = 2;
            label2.Text = "Winner";
            label2.Click += label2_Click;
            // 
            // laTurn
            // 
            laTurn.AutoSize = true;
            laTurn.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            laTurn.ForeColor = Color.White;
            laTurn.Location = new Point(42, 188);
            laTurn.Name = "laTurn";
            laTurn.Size = new Size(139, 35);
            laTurn.TabIndex = 3;
            laTurn.Text = "Player1";
            // 
            // laWinner
            // 
            laWinner.AutoSize = true;
            laWinner.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            laWinner.ForeColor = Color.Lime;
            laWinner.Location = new Point(22, 271);
            laWinner.Name = "laWinner";
            laWinner.Size = new Size(204, 35);
            laWinner.TabIndex = 4;
            laWinner.Text = "In Progrees";
            // 
            // btRestart
            // 
            btRestart.BackColor = Color.Red;
            btRestart.Location = new Point(32, 324);
            btRestart.Name = "btRestart";
            btRestart.Size = new Size(181, 54);
            btRestart.TabIndex = 5;
            btRestart.Text = "Restart";
            btRestart.UseVisualStyleBackColor = false;
            btRestart.Click += btRestart_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.question_mark_96;
            pictureBox2.Location = new Point(261, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "?";
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.question_mark_96;
            pictureBox3.Location = new Point(430, 84);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 78);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "?";
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.question_mark_96;
            pictureBox4.Location = new Point(633, 84);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 78);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "?";
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.question_mark_96;
            pictureBox5.Location = new Point(261, 193);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(128, 78);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "?";
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.question_mark_96;
            pictureBox7.Location = new Point(633, 193);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(128, 78);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "?";
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.question_mark_96;
            pictureBox11.Location = new Point(633, 324);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(128, 78);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 11;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "?";
            pictureBox11.Click += pictureBox11_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.question_mark_96;
            pictureBox12.Location = new Point(430, 324);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(128, 78);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 10;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "?";
            pictureBox12.Click += pictureBox12_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.question_mark_96;
            pictureBox13.Location = new Point(261, 324);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(128, 78);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 9;
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "?";
            pictureBox13.Click += pictureBox13_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.question_mark_96;
            pictureBox6.Location = new Point(430, 193);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(128, 78);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "?";
            pictureBox6.Click += pictureBox6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(853, 503);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btRestart);
            Controls.Add(laWinner);
            Controls.Add(laTurn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label laTurn;
        private Label laWinner;
        private Button btRestart;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox6;
    }
}
