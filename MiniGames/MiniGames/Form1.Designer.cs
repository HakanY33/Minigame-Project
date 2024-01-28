namespace MiniGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Properties.button();
            button2 = new Properties.button();
            button3 = new Properties.button();
            button4 = new Properties.button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(755, 28);
            label1.Name = "label1";
            label1.Size = new Size(364, 79);
            label1.TabIndex = 1;
            label1.Text = "Mini Games";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1263, 676);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.BackgroundColor = Color.LightCyan;
            button1.BorderColor = Color.Peru;
            button1.BorderRadius = 50;
            button1.BorderSize = 1;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(357, 153);
            button1.Name = "button1";
            button1.Size = new Size(200, 200);
            button1.TabIndex = 2;
            button1.Text = "CivCiv Puzzle";
            button1.TextColor = Color.Red;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.BackgroundColor = Color.LightCyan;
            button2.BorderColor = Color.Peru;
            button2.BorderRadius = 50;
            button2.BorderSize = 1;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(357, 395);
            button2.Name = "button2";
            button2.Size = new Size(200, 200);
            button2.TabIndex = 3;
            button2.Text = "2048";
            button2.TextColor = Color.Red;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCyan;
            button3.BackgroundColor = Color.LightCyan;
            button3.BorderColor = Color.Peru;
            button3.BorderRadius = 50;
            button3.BorderSize = 1;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(755, 153);
            button3.Name = "button3";
            button3.Size = new Size(200, 200);
            button3.TabIndex = 5;
            button3.Text = "Break the Brick";
            button3.TextColor = Color.Red;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCyan;
            button4.BackgroundColor = Color.LightCyan;
            button4.BorderColor = Color.Peru;
            button4.BorderRadius = 50;
            button4.BorderSize = 1;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(755, 395);
            button4.Name = "button4";
            button4.Size = new Size(200, 200);
            button4.TabIndex = 4;
            button4.Text = "Snake Game";
            button4.TextColor = Color.Red;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 673);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Properties.button button1;
        private Properties.button button2;
        private Properties.button button3;
        private Properties.button button4;
    }
}