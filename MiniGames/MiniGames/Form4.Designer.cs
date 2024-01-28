namespace MiniGames
{
    partial class Form4
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
            txtScore = new Label();
            player = new PictureBox();
            ball = new PictureBox();
            gameTImer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.ForeColor = Color.White;
            txtScore.Location = new Point(17, 20);
            txtScore.Margin = new Padding(4, 0, 4, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(110, 29);
            txtScore.TabIndex = 0;
            txtScore.Text = "Score: 0";
            // 
            // player
            // 
            player.BackColor = Color.White;
            player.Location = new Point(331, 527);
            player.Margin = new Padding(4, 5, 4, 5);
            player.Name = "player";
            player.Size = new Size(133, 49);
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // ball
            // 
            ball.BackColor = Color.Yellow;
            ball.Image = Properties.Resources.yellowball;
            ball.Location = new Point(381, 434);
            ball.Margin = new Padding(4, 5, 4, 5);
            ball.Name = "ball";
            ball.Size = new Size(35, 35);
            ball.SizeMode = PictureBoxSizeMode.StretchImage;
            ball.TabIndex = 1;
            ball.TabStop = false;
            // 
            // gameTImer
            // 
            gameTImer.Interval = 20;
            gameTImer.Tick += mainGameTimerEvent;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(321, 142);
            button1.Name = "button1";
            button1.Size = new Size(157, 63);
            button1.TabIndex = 2;
            button1.Text = "Main Menü";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(835, 590);
            Controls.Add(button1);
            Controls.Add(ball);
            Controls.Add(player);
            Controls.Add(txtScore);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form4";
            Text = "Break the Break";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtScore;
        private PictureBox player;
        private PictureBox ball;
        private System.Windows.Forms.Timer gameTImer;
        private Button button1;
    }
}