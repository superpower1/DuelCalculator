using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeulCalculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int initLife = 8000;
        int temp = 0;

        public void addNum(int num)
        {
            lifeChange.Text = lifeChange.Text + num.ToString();
        }

        private void lifeChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            addNum(1);
        }

        private void num2_Click(object sender, EventArgs e)
        {
            addNum(2);
        }

        private void num3_Click(object sender, EventArgs e)
        {
            addNum(3);
        }

        private void num4_Click(object sender, EventArgs e)
        {
            addNum(4);
        }

        private void num5_Click(object sender, EventArgs e)
        {
            addNum(5);
        }

        private void num6_Click(object sender, EventArgs e)
        {
            addNum(6);
        }

        private void num7_Click(object sender, EventArgs e)
        {
            addNum(7);
        }

        private void num8_Click(object sender, EventArgs e)
        {
            addNum(8);
        }

        private void num9_Click(object sender, EventArgs e)
        {
            addNum(9);
        }

        private void num0_Click(object sender, EventArgs e)
        {
            addNum(0);
        }

        private void num00_Click(object sender, EventArgs e)
        {
            addNum(0);
            addNum(0);
        }

        private void num000_Click(object sender, EventArgs e)
        {
            addNum(0);
            addNum(0);
            addNum(0);
        }

        private void player1minus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(lifeChange.Text);
            lifeChange.Text = "";
            int tempLife = Convert.ToInt32(player1life.Text);
            if (tempLife - temp < 0)
            {
                player1life.Text = "0";
            }
            else {
                player1life.Text = (tempLife-temp).ToString();
            }
            
        }

        private void player1plus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(lifeChange.Text);
            lifeChange.Text = "";
            int tempLife = Convert.ToInt32(player1life.Text);
            player1life.Text = (tempLife + temp).ToString();
        }

        private void player2minus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(lifeChange.Text);
            lifeChange.Text = "";
            int tempLife = Convert.ToInt32(player2life.Text);
            if (tempLife - temp < 0)
            {
                player2life.Text = "0";
            }
            else
            {
                player2life.Text = (tempLife - temp).ToString();
            }
        }

        private void player2plus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(lifeChange.Text);
            lifeChange.Text = "";
            int tempLife = Convert.ToInt32(player2life.Text);
            player2life.Text = (tempLife + temp).ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            player1life.Text = "8000";
            player2life.Text = "8000";
            temp = 0;
        }

        private void ac_Click(object sender, EventArgs e)
        {
            lifeChange.Text = "";
        }

        private void player1half_Click(object sender, EventArgs e)
        {
            int tempLife = Convert.ToInt32(player1life.Text);
            player1life.Text = (tempLife / 2).ToString();
        }

        private void player2half_Click(object sender, EventArgs e)
        {
            int tempLife = Convert.ToInt32(player2life.Text);
            player2life.Text = (tempLife / 2).ToString();
        }

        private void player1change_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(lifeChange.Text);
            lifeChange.Text = "";
            player1life.Text = temp.ToString();
        }

        private void player2change_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(lifeChange.Text);
            lifeChange.Text = "";
            player2life.Text = temp.ToString();
        }

        private void rollDice_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int i = rd.Next(1, 7);
            MessageBox.Show(Convert.ToString(i));
        }

        private void tossCoin_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int i = rd.Next() % 2;
            switch (i) {
                case 0: MessageBox.Show("HEAD");
                    break;
                case 1: MessageBox.Show("TAIL");
                    break;
            }
            
        }
    }
}
