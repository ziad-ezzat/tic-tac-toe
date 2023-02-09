using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class myBoard : Form
    {
        private int[,] Board;
        private int CurrentPlayer;
        private int Player1Score;
        private int Player2Score;
        public myBoard()
        {
            InitializeComponent();
        }
        private void myBoard_Load_1(object sender, EventArgs e)
        {
            Board = new int[3, 3];
            Player2Score = 0;
            Player1Score = 0;
            CurrentPlayer = 1;
        }


        private bool IsAWinner(int player)
        {
            bool win = false;
            // check rows
            for (int i = 0; i < 3; i++)
            {
                win = true;
                for (int j = 0; j < 3; j++)
                {
                    if (Board[i, j] != player) win = false;
                }
                if (win) { return true; }
            }

            // check columns
            for (int i = 0; i < 3; i++)
            {
                win = true;
                for (int j = 0; j < 3; j++)
                {
                    if (Board[j, i] != player) win = false;
                }
                if (win) { return true; }
            }

            // / diagonal
            win = true;
            for (int i = 0; i < 3; i++)
            {
                if (Board[i, i] != player) win = false;
            }
            if (win) { return true; }

            // \ diagonal
            win = true;
            for (int i = 0; i < 3; i++)
            {
                if (Board[i, 2 - i] != player) win = false;
            }
            if (win) { return true; }

            return false;
        }

        private bool IsFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Board[i, j] == 0) return false;
                }
            }
            return true;
        }


        private void DisableBoard(bool isDisabled)
        {
            button1.Enabled = isDisabled;
            button2.Enabled = isDisabled;
            button3.Enabled = isDisabled;
            button4.Enabled = isDisabled;
            button5.Enabled = isDisabled;
            button6.Enabled = isDisabled;
            button7.Enabled = isDisabled;
            button8.Enabled = isDisabled;
            button9.Enabled = isDisabled;
        }


        private void ApplyMove(int row, int col)
        {
            Board[row, col] = CurrentPlayer;
            bool isWinner = IsAWinner(CurrentPlayer);
            if (isWinner)
            {
                MessageBox.Show($"Player {(CurrentPlayer == 1 ? "X" : "O")}");
                if (CurrentPlayer == 1)
                {
                    Player1Score += 1;
                    tx_playeroneScore.Text = Player1Score.ToString();
                }

                else
                {
                    Player2Score += 1;
                    tb_playertwoScore.Text = Player2Score.ToString();
                }
                DisableBoard(false);
            }
            else
            {
                bool isFull = IsFull();
                if (isFull)
                {
                    MessageBox.Show("No one wins.");
                    DisableBoard(false);
                }
                else
                {
                    CurrentPlayer = CurrentPlayer == 1 ? 2 : 1;
                }
            }
        }

        private void ClearBoard()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(0, 0);
            button1.Enabled = false;
        }
       


        private void btn_newgame_Click(object sender, EventArgs e)
        {
            Board = new int[3, 3];
            CurrentPlayer = 1;
            ClearBoard();
            DisableBoard(true);
        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
            btn_newgame_Click(null, null);
            Player1Score = 0;
            Player2Score = 0;
            tx_playeroneScore.Text = "0";
            tb_playertwoScore.Text = "0";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(0, 1);
            button2.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(0, 2);
            button3.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(1, 0);
            button4.Enabled = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(1, 1);
            button5.Enabled = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button6.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(1, 2);
            button6.Enabled = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            button7.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(2, 0);
            button7.Enabled = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            button8.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(2, 1);
            button8.Enabled = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            button9.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(2, 2);
            button9.Enabled = false;
        }
    }
}
