using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames
{
    public partial class Form2 : Form
    {
        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> firstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();


        public Form2()
        {
            InitializeComponent();
            firstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
            label1.Text += inmoves;
            label2.Text = "00:00:00";
        }


        private void SwitchPictureBox(object sender, EventArgs e)
        {
            if (label2.Text == "00:00:00")
                timer.Start();
            int inPictureBoxIndex = groupBox1.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { inPictureBoxIndex - 1, inPictureBoxIndex - 3, inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    ((PictureBox)groupBox1.Controls[inNullSliceIndex]).Image = ((PictureBox)groupBox1.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)groupBox1.Controls[inPictureBoxIndex]).Image = firstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    label1.Text = "Moves Made : " + (++inmoves);
                    if (CheckWin())
                    {
                        timer.Stop();
                        (groupBox1.Controls[8] as PictureBox).Image = firstOriginalPictureList[8];
                        MessageBox.Show("Congratulations...\n Your CivCiv Is Happy \n Time Elapsed : " + timer.Elapsed.ToString().Remove(8) + "\n Total Moves Made : " + inmoves, "CivCiv Puzzle");
                        inmoves = 0;
                        label1.Text = "Moves Made : 0";
                        label2.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();
                    }
                }
            }
        }


        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 }); //8 is not present   until it is the last slice
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)groupBox1.Controls[i]).Image = firstOriginalPictureList[j];
                    if (j == 9) inNullSliceIndex = i;
                }
            } while (CheckWin());
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            Shuffle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormClosed += Form2_FormClosed;
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] != null)
            {
                Application.OpenForms["Form1"].Show();
            }
        }



        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((groupBox1.Controls[i] as PictureBox).Image != firstOriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult YesorNo = new DialogResult();
            if (label2.Text != "00:00:00")
            {
                YesorNo = MessageBox.Show("Are You sure to Restart ?", "CivCiv Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesorNo == DialogResult.Yes || label2.Text == "00:00:00")
            {
                Shuffle();
                timer.Reset();
                label2.Text = "00:00:00";
                inmoves = 0;
                label1.Text = "Moves Made : 0";
            }
        }

        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                label2.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                button3.Enabled = false;
            else
                button3.Enabled = true;
            if (timer.Elapsed.Minutes.ToString() == "1")
            {
                timer.Reset();
                label1.Text = "Moves Made : 0";
                label2.Text = "00:00:00";
                inmoves = 0;
                button3.Enabled = false;
                MessageBox.Show("Time is Up \n Try Again", "CivCiv Puzzle");
                Shuffle();
            }
        }


        private void AskPermissionBeforeQuite(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Are You Sure To Quit ?", "CivCiv Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != button1 && YesOrNO == DialogResult.No) e.Cancel = true;
            if (sender as Button == button1 && YesOrNO == DialogResult.Yes) Environment.Exit(0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Pause")
            {
                timer.Stop();
                groupBox1.Visible = false;
                button3.Text = "Resume";
            }
            else
            {
                timer.Start();
                groupBox1.Visible = true;
                button3.Text = "Pause";
            }
        }
    }
}
