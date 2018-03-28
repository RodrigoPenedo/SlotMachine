using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreditsLbl.Text = Credits.ToString();
        }
        
        int[] Results = new int[5] { 1, 2, 3, 4, 5 };
        int Score = 0;
        int Credits = 15;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChangePictures(int Slot, int value)
        {
            PictureBox Current = PicBox1;

            switch (Slot)
            {
                case 1: Current = PicBox1; break;
                case 2: Current = PicBox2; break;
                case 3: Current = PicBox3; break;
            }

            switch (value)
            {
                case 1: Current.BackColor = Color.Blue; break;
                case 2: Current.BackColor = Color.Red; break;
                case 3: Current.BackColor = Color.Orange; break;
                case 4: Current.BackColor = Color.Green; break;
                case 5: Current.BackColor = Color.Purple; break;
            }
        }

        private void SpinBtn_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            int number = n.Next(1, 6);

            ChangePictures(1, number);

            number = n.Next(1, 6);

            ChangePictures(2, number);

            number = n.Next(1, 6);

            ChangePictures(3, number);

            if (PicBox1.BackColor == PicBox2.BackColor && PicBox2.BackColor == PicBox3.BackColor)
            {
                Color colour = PicBox1.BackColor;

                if (colour == Color.Blue)
                {
                    Score += 100;
                }
                else if (colour == Color.Red)
                {
                    Score += 200;
                }
                else if (colour == Color.Orange)
                {
                    Score += 500;
                }
                else if (colour == Color.Green)
                {
                    Score += 1000;
                }
                else if (colour == Color.Purple)
                {
                    Score += 10000;
                }

                Credits += 1;
            }

            Credits -= 1;

            ScoreLbl.Text = Score.ToString();
            CreditsLbl.Text = Credits.ToString();
            
            if (Credits == 0)
            {
                SpinBtn.Enabled = false;
                MessageBox.Show("Out of Credits!");
            }
        }
    }
}
