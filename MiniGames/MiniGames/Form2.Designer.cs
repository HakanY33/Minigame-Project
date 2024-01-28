namespace MiniGames
{
    partial class Form2
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
            button1 = new Properties.button();
            groupBox1 = new GroupBox();
            pbx9 = new PictureBox();
            pbx8 = new PictureBox();
            pbx7 = new PictureBox();
            pbx6 = new PictureBox();
            pbx5 = new PictureBox();
            pbx4 = new PictureBox();
            pbx3 = new PictureBox();
            pbx2 = new PictureBox();
            pbx1 = new PictureBox();
            groupBox2 = new GroupBox();
            mainpbx = new PictureBox();
            button2 = new Properties.button();
            button3 = new Properties.button();
            label1 = new Label();
            label2 = new Label();
            timeElapsed = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainpbx).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.BackgroundColor = Color.Crimson;
            button1.BorderColor = Color.PaleVioletRed;
            button1.BorderRadius = 40;
            button1.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(957, 631);
            button1.Name = "button1";
            button1.Size = new Size(108, 50);
            button1.TabIndex = 0;
            button1.Text = "↩️";
            button1.TextColor = Color.White;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbx9);
            groupBox1.Controls.Add(pbx8);
            groupBox1.Controls.Add(pbx7);
            groupBox1.Controls.Add(pbx6);
            groupBox1.Controls.Add(pbx5);
            groupBox1.Controls.Add(pbx4);
            groupBox1.Controls.Add(pbx3);
            groupBox1.Controls.Add(pbx2);
            groupBox1.Controls.Add(pbx1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 599);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "PuzzleBox";
            // 
            // pbx9
            // 
            pbx9.Location = new Point(378, 398);
            pbx9.Name = "pbx9";
            pbx9.Size = new Size(180, 180);
            pbx9.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx9.TabIndex = 8;
            pbx9.TabStop = false;
            pbx9.Click += SwitchPictureBox;
            // 
            // pbx8
            // 
            pbx8.Location = new Point(192, 398);
            pbx8.Name = "pbx8";
            pbx8.Size = new Size(180, 180);
            pbx8.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx8.TabIndex = 7;
            pbx8.TabStop = false;
            pbx8.Click += SwitchPictureBox;
            // 
            // pbx7
            // 
            pbx7.Location = new Point(6, 398);
            pbx7.Name = "pbx7";
            pbx7.Size = new Size(180, 180);
            pbx7.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx7.TabIndex = 6;
            pbx7.TabStop = false;
            pbx7.Click += SwitchPictureBox;
            // 
            // pbx6
            // 
            pbx6.Location = new Point(378, 212);
            pbx6.Name = "pbx6";
            pbx6.Size = new Size(180, 180);
            pbx6.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx6.TabIndex = 5;
            pbx6.TabStop = false;
            pbx6.Click += SwitchPictureBox;
            // 
            // pbx5
            // 
            pbx5.Location = new Point(192, 212);
            pbx5.Name = "pbx5";
            pbx5.Size = new Size(180, 180);
            pbx5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx5.TabIndex = 4;
            pbx5.TabStop = false;
            pbx5.Click += SwitchPictureBox;
            // 
            // pbx4
            // 
            pbx4.Location = new Point(6, 212);
            pbx4.Name = "pbx4";
            pbx4.Size = new Size(180, 180);
            pbx4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx4.TabIndex = 3;
            pbx4.TabStop = false;
            pbx4.Click += SwitchPictureBox;
            // 
            // pbx3
            // 
            pbx3.Location = new Point(378, 26);
            pbx3.Name = "pbx3";
            pbx3.Size = new Size(180, 180);
            pbx3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx3.TabIndex = 2;
            pbx3.TabStop = false;
            pbx3.Click += SwitchPictureBox;
            // 
            // pbx2
            // 
            pbx2.Location = new Point(192, 26);
            pbx2.Name = "pbx2";
            pbx2.Size = new Size(180, 180);
            pbx2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx2.TabIndex = 1;
            pbx2.TabStop = false;
            pbx2.Click += SwitchPictureBox;
            // 
            // pbx1
            // 
            pbx1.Location = new Point(6, 26);
            pbx1.Name = "pbx1";
            pbx1.Size = new Size(180, 180);
            pbx1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx1.TabIndex = 0;
            pbx1.TabStop = false;
            pbx1.Click += SwitchPictureBox;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mainpbx);
            groupBox2.Location = new Point(644, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(463, 480);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Original";
            // 
            // mainpbx
            // 
            mainpbx.Image = Properties.Resources.original;
            mainpbx.Location = new Point(6, 30);
            mainpbx.Name = "mainpbx";
            mainpbx.Size = new Size(450, 450);
            mainpbx.SizeMode = PictureBoxSizeMode.StretchImage;
            mainpbx.TabIndex = 0;
            mainpbx.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSlateBlue;
            button2.BackgroundColor = Color.MediumSlateBlue;
            button2.BorderColor = Color.PaleVioletRed;
            button2.BorderRadius = 40;
            button2.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(650, 631);
            button2.Name = "button2";
            button2.Size = new Size(125, 50);
            button2.TabIndex = 3;
            button2.Text = "Shuffle";
            button2.TextColor = Color.White;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSlateBlue;
            button3.BackgroundColor = Color.MediumSlateBlue;
            button3.BorderColor = Color.PaleVioletRed;
            button3.BorderRadius = 40;
            button3.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(797, 631);
            button3.Name = "button3";
            button3.Size = new Size(125, 50);
            button3.TabIndex = 4;
            button3.Text = "Pause";
            button3.TextColor = Color.White;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(31, 653);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 6;
            label1.Text = "Moves Made:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(741, 509);
            label2.Name = "label2";
            label2.Size = new Size(253, 81);
            label2.TabIndex = 7;
            label2.Text = "00:00:00";
            // 
            // timeElapsed
            // 
            timeElapsed.Enabled = true;
            timeElapsed.Interval = 900;
            timeElapsed.Tick += UpdateTimeElapsed;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 767);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            FormClosing += AskPermissionBeforeQuite;
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainpbx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Properties.button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Properties.button button2;
        private Properties.button button3;
        private Label label1;
        private PictureBox pbx9;
        private PictureBox pbx8;
        private PictureBox pbx7;
        private PictureBox pbx6;
        private PictureBox pbx5;
        private PictureBox pbx4;
        private PictureBox pbx3;
        private PictureBox pbx2;
        private PictureBox pbx1;
        private PictureBox mainpbx;
        private Label label2;
        private System.Windows.Forms.Timer timeElapsed;
    }
}