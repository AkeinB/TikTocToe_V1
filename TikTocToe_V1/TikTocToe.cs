using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTocToe_V1
{
    public partial class TikTocToe : Form
    {
        public string _Player1 = "X";
        public string _Player2 = "O";
        public string _CurrentPlayer = null;
        public bool win = false;
        public TikTocToe()
        {
            InitializeComponent();  
        }

        private void TikTokToe_Load(object sender, EventArgs e)
        {
            this.ActiveControl = groupBox1;
            LB_Player1.ForeColor = Color.Red;
            _CurrentPlayer = _Player1;
            BTN_Section_1.Text = " ";
            BTN_Section_2.Text = " ";
            BTN_Section_3.Text = " ";
            BTN_Section_4.Text = " ";
            BTN_Section_5.Text = " ";
            BTN_Section_6.Text = " ";
            BTN_Section_7.Text = " ";
            BTN_Section_8.Text = " ";
            BTN_Section_9.Text = " ";
        }

        private void BTN_Section_1_Click(object sender, EventArgs e)
        {
            if(BTN_Section_1.Text == " ")
            {
                BTN_Section_1.Text = _CurrentPlayer;
               
                CheckWin();
                checkDraw();

                _CurrentPlayer = PlayerTurn(_CurrentPlayer);
            }
            
            
        }

        private void BTN_Section_2_Click(object sender, EventArgs e)
        {
            if (BTN_Section_2.Text == " ")
            {
                BTN_Section_2.Text = _CurrentPlayer;
                CheckWin();
                checkDraw();
                _CurrentPlayer = PlayerTurn(_CurrentPlayer);
            }
              
        }

        private void BTN_Section_3_Click(object sender, EventArgs e)
        {
            if (BTN_Section_3.Text == " ")
            {
                BTN_Section_3.Text = _CurrentPlayer;
               
                CheckWin();
                checkDraw();
                _CurrentPlayer = PlayerTurn(_CurrentPlayer);
            }
        }

        private void BTN_Section_4_Click(object sender, EventArgs e)
        {
            if (BTN_Section_4.Text == " ")
            {
                BTN_Section_4.Text = _CurrentPlayer;
                
                CheckWin();
                checkDraw();
                _CurrentPlayer = PlayerTurn(_CurrentPlayer);
            }
               
        }

        private void BTN_Section_5_Click(object sender, EventArgs e)
        {
            if (BTN_Section_5.Text == " ")
            {
                BTN_Section_5.Text = _CurrentPlayer;
                
                CheckWin();
                checkDraw();
                _CurrentPlayer = PlayerTurn(_CurrentPlayer);
            }
               
        }

        private void BTN_Section_6_Click(object sender, EventArgs e)
        {
            if (BTN_Section_6.Text == " ")
            {
                BTN_Section_6.Text = _CurrentPlayer;
                
                CheckWin();
                checkDraw();
                _CurrentPlayer = PlayerTurn(_CurrentPlayer);
            }
               
        }

        private void BTN_Section_7_Click(object sender, EventArgs e)
        {
            if (BTN_Section_7.Text == " ")
            {
                BTN_Section_7.Text = _CurrentPlayer;
                
                CheckWin();
                checkDraw();
                _CurrentPlayer = PlayerTurn(_CurrentPlayer);
            }
               
        }

        private void BTN_Section_8_Click(object sender, EventArgs e)
        {
            if (BTN_Section_8.Text == " ")
            {
                BTN_Section_8.Text = _CurrentPlayer;
                
                CheckWin();
                checkDraw();
                _CurrentPlayer = PlayerTurn(_CurrentPlayer);
            }
               
        }

        private void BTN_Section_9_Click(object sender, EventArgs e)
        {
            if (BTN_Section_9.Text == " ")
            {
                BTN_Section_9.Text = _CurrentPlayer;
                
                CheckWin();
                checkDraw();
                _CurrentPlayer = PlayerTurn(_CurrentPlayer);
            }
               
        }

        private void BTN_ClearBoard_Click(object sender, EventArgs e)
        {
            RestBoard();
        }


        //checks the current player turn and assigns the next player
        public string PlayerTurn(string currentPalyer)
        {
            LB_Player1.ForeColor = Color.Red;

            if (currentPalyer == _Player1)
            {
                currentPalyer = _Player2;
                LB_Player2.ForeColor = Color.Red;
                LB_Player1.ForeColor = Color.Black;
            }
            else
            {
                currentPalyer = _Player1;
                LB_Player1.ForeColor = Color.Red;
                LB_Player2.ForeColor = Color.Black;
            }

            return currentPalyer;
        }

        //check for win conditions
        public void CheckWin()
        {
            

            //check for horizontal win conditions in row 1, 2, and 3
            if (BTN_Section_1.Text == _CurrentPlayer
                && BTN_Section_2.Text == _CurrentPlayer
                && BTN_Section_3.Text == _CurrentPlayer
                && BTN_Section_1.Text != " "
                && BTN_Section_2.Text != " "
                && BTN_Section_3.Text != " ")
            {
                win = true;
            }
            if (BTN_Section_4.Text == _CurrentPlayer
                 && BTN_Section_5.Text == _CurrentPlayer
                 && BTN_Section_6.Text == _CurrentPlayer
                 && BTN_Section_5.Text != " "
                 && BTN_Section_6.Text != " "
                 && BTN_Section_7.Text != " ")
            {
                win = true;
            }
            if (BTN_Section_7.Text == _CurrentPlayer
                && BTN_Section_8.Text == _CurrentPlayer
                && BTN_Section_9.Text == _CurrentPlayer
                && BTN_Section_7.Text != " "
                && BTN_Section_8.Text != " "
                && BTN_Section_9.Text != " ")
            {
                win = true;
            }

            //check for vertical win conditions in column 1, 2, and 3
            if (BTN_Section_1.Text == _CurrentPlayer
                && BTN_Section_4.Text == _CurrentPlayer
                && BTN_Section_7.Text == _CurrentPlayer
                && BTN_Section_1.Text != " "
                && BTN_Section_4.Text != " "
                && BTN_Section_7.Text != " ")
            {
                win = true;
            }
            if (BTN_Section_2.Text == _CurrentPlayer
               && BTN_Section_5.Text == _CurrentPlayer
               && BTN_Section_8.Text == _CurrentPlayer
               && BTN_Section_2.Text != " "
               && BTN_Section_5.Text != " "
               && BTN_Section_8.Text != " ")
            {
                win = true;
            }
            if (BTN_Section_3.Text == _CurrentPlayer
               && BTN_Section_6.Text == _CurrentPlayer
               && BTN_Section_9.Text == _CurrentPlayer
               && BTN_Section_3.Text != " "
               && BTN_Section_6.Text != " "
               && BTN_Section_9.Text != " ")
            {
                win = true;
            }

            //check for diagonal win conditions in diagonal 1 and 2
            if (BTN_Section_1.Text == _CurrentPlayer
                && BTN_Section_5.Text == _CurrentPlayer
                && BTN_Section_9.Text == _CurrentPlayer
                && BTN_Section_1.Text != " "
                && BTN_Section_5.Text != " "
                && BTN_Section_9.Text != " ")
            {
                win = true;
            }
            if (BTN_Section_3.Text == _CurrentPlayer
                && BTN_Section_5.Text == _CurrentPlayer
                && BTN_Section_7.Text == _CurrentPlayer
                && BTN_Section_3.Text != " "
                && BTN_Section_5.Text != " "
                && BTN_Section_7.Text != " ")
            {
                win = true;
            }

            //if win conditions are met, display a message box and reset the game board
            if (win)
            {
                MessageBox.Show($"{_CurrentPlayer} Wins!");
                RestBoard();
            }
            
        }
        //check for draw conditions
        public void checkDraw()
        {
           

            if (win == false)
            {
                if (BTN_Section_1.Text != " "
                    && BTN_Section_2.Text != " "
                    && BTN_Section_3.Text != " "
                    && BTN_Section_4.Text != " "
                    && BTN_Section_5.Text != " "
                    && BTN_Section_6.Text != " "
                    && BTN_Section_7.Text != " "
                    && BTN_Section_8.Text != " "
                    && BTN_Section_9.Text != " ")
                {
                    MessageBox.Show(" Draw! ");
                    RestBoard();
                    
                }
            }
            win = false;
        }

        public void RestBoard()
        {
            _CurrentPlayer = _Player2;
            BTN_Section_1.Text = " ";
            BTN_Section_2.Text = " ";
            BTN_Section_3.Text = " ";
            BTN_Section_4.Text = " ";
            BTN_Section_5.Text = " ";
            BTN_Section_6.Text = " ";
            BTN_Section_7.Text = " ";
            BTN_Section_8.Text = " ";
            BTN_Section_9.Text = " ";
        }

    }

}
