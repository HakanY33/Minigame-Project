namespace MiniGames
{
    partial class Form5
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
            components = new System.ComponentModel.Container();
            timer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            mainmenu = new Properties.button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            HighScore = new Label();
            CurrentScore = new Label();
            label1 = new Label();
            label3 = new Label();
            GameOverLabel = new Label();
            startButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(mainmenu);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(HighScore);
            panel1.Controls.Add(CurrentScore);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(GameOverLabel);
            panel1.Controls.Add(startButton);
            panel1.Location = new Point(635, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 654);
            panel1.TabIndex = 1;
            // 
            // mainmenu
            // 
            mainmenu.BackColor = Color.Crimson;
            mainmenu.BackgroundColor = Color.Crimson;
            mainmenu.BorderColor = Color.PaleVioletRed;
            mainmenu.BorderRadius = 40;
            mainmenu.BorderSize = 0;
            mainmenu.FlatAppearance.BorderSize = 0;
            mainmenu.FlatStyle = FlatStyle.Flat;
            mainmenu.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mainmenu.ForeColor = Color.White;
            mainmenu.Location = new Point(23, 385);
            mainmenu.Name = "mainmenu";
            mainmenu.Size = new Size(188, 61);
            mainmenu.TabIndex = 3;
            mainmenu.Text = "Ana Menu";
            mainmenu.TextColor = Color.White;
            mainmenu.UseVisualStyleBackColor = false;
            mainmenu.Visible = false;
            mainmenu.Click += mainmenu_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Items.AddRange(new object[] { "Kolay", "Normal", "Zor", "Bu ne Lan" });
            comboBox1.Location = new Point(37, 251);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 28);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(33, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 23);
            label2.TabIndex = 1;
            label2.Text = "En Yüksek Skor: ";
            // 
            // HighScore
            // 
            HighScore.AutoSize = true;
            HighScore.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            HighScore.Location = new Point(168, 137);
            HighScore.Margin = new Padding(4, 0, 4, 0);
            HighScore.Name = "HighScore";
            HighScore.RightToLeft = RightToLeft.No;
            HighScore.Size = new Size(26, 30);
            HighScore.TabIndex = 1;
            HighScore.Text = "0";
            HighScore.TextAlign = ContentAlignment.TopRight;
            // 
            // CurrentScore
            // 
            CurrentScore.AutoSize = true;
            CurrentScore.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CurrentScore.Location = new Point(168, 91);
            CurrentScore.Margin = new Padding(4, 0, 4, 0);
            CurrentScore.Name = "CurrentScore";
            CurrentScore.Size = new Size(26, 30);
            CurrentScore.TabIndex = 1;
            CurrentScore.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(33, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 1;
            label1.Text = "Skor: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 208);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(246, 34);
            label3.TabIndex = 1;
            label3.Text = "Zorluk Derecesi:";
            // 
            // GameOverLabel
            // 
            GameOverLabel.AutoSize = true;
            GameOverLabel.BorderStyle = BorderStyle.FixedSingle;
            GameOverLabel.FlatStyle = FlatStyle.Popup;
            GameOverLabel.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            GameOverLabel.ForeColor = Color.DarkRed;
            GameOverLabel.Location = new Point(33, 38);
            GameOverLabel.Margin = new Padding(4, 0, 4, 0);
            GameOverLabel.Name = "GameOverLabel";
            GameOverLabel.Size = new Size(165, 35);
            GameOverLabel.TabIndex = 1;
            GameOverLabel.Text = "Oyun Bitti";
            // 
            // startButton
            // 
            startButton.Location = new Point(66, 602);
            startButton.Margin = new Padding(4, 5, 4, 5);
            startButton.Name = "startButton";
            startButton.Size = new Size(100, 35);
            startButton.TabIndex = 0;
            startButton.Text = "Başla";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += BeginButtonClicked;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(893, 692);
            ControlBox = false;
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            RightToLeft = RightToLeft.No;
            Text = "Snake Game";
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private Panel panel1;
        private Button startButton;
        private Label label2;
        private Label HighScore;
        private Label CurrentScore;
        private Label label1;
        private Label GameOverLabel;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private Properties.button mainmenu;
    }
}