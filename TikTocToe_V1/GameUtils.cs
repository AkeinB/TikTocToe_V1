using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTocToe_V1
{
    internal class GameUtils
    {
        private static TikTocToe Game = new TikTocToe();


        //checks the current player turn and assigns the next player
        static public string PlayerTurn(string currentPalyer)
        {
            if(currentPalyer == Game._Player1)
            {
                currentPalyer = Game._Player2;
            }
            else 
            {
                currentPalyer = Game._Player1;
            }

            return currentPalyer;
        }


        //check for win conditions
        public static bool CheckWin()
        {
            bool win = false;

            //check for horizontal win conditions in row 1, 2, and 3
            if (Game.BTN_Section_1.Text == Game._CurrentPlayer
                && Game.BTN_Section_2.Text == Game._CurrentPlayer 
                && Game.BTN_Section_3.Text == Game._CurrentPlayer
                && Game.BTN_Section_1.Text != " "
                && Game.BTN_Section_2.Text != " "
                && Game.BTN_Section_3.Text != " ")
            {
                win = true;
            }
            if (Game.BTN_Section_4.Text == Game._CurrentPlayer
                 && Game.BTN_Section_5.Text == Game._CurrentPlayer
                 && Game.BTN_Section_6.Text == Game._CurrentPlayer
                 && Game.BTN_Section_5.Text != " "
                 && Game.BTN_Section_6.Text != " "
                 && Game.BTN_Section_7.Text != " ")
            { 
                win = true;
            }
            if (Game.BTN_Section_7.Text == Game._CurrentPlayer
                && Game.BTN_Section_8.Text == Game._CurrentPlayer
                && Game.BTN_Section_9.Text == Game._CurrentPlayer
                && Game.BTN_Section_7.Text != " "
                && Game.BTN_Section_8.Text != " "
                && Game.BTN_Section_9.Text != " ")
            {
                
                win = true;
            }
            //check for vertical win conditions in column 1, 2, and 3
            if (Game.BTN_Section_1.Text == Game._CurrentPlayer
                && Game.BTN_Section_4.Text == Game._CurrentPlayer
                && Game.BTN_Section_7.Text == Game._CurrentPlayer
                && Game.BTN_Section_1.Text != " "
                && Game.BTN_Section_4.Text != " "
                && Game.BTN_Section_7.Text != " ")
            {
                win = true;
            }
            if (Game.BTN_Section_2.Text == Game._CurrentPlayer
               && Game.BTN_Section_5.Text == Game._CurrentPlayer
               && Game.BTN_Section_8.Text == Game._CurrentPlayer
               && Game.BTN_Section_2.Text != " "
               && Game.BTN_Section_5.Text != " "
               && Game.BTN_Section_8.Text != " ")
            {
               win = true;
            }
            if (Game.BTN_Section_3.Text == Game._CurrentPlayer
               && Game.BTN_Section_6.Text == Game._CurrentPlayer
               && Game.BTN_Section_9.Text == Game._CurrentPlayer
               && Game.BTN_Section_3.Text != " "
               && Game.BTN_Section_6.Text != " "
               && Game.BTN_Section_9.Text != " ")
            {
               win = true;
            }

            //check for diagonal win conditions in diagonal 1 and 2
            if (Game.BTN_Section_1.Text == Game._CurrentPlayer
                && Game.BTN_Section_5.Text == Game._CurrentPlayer
                && Game.BTN_Section_9.Text == Game._CurrentPlayer
                && Game.BTN_Section_1.Text != " "
                && Game.BTN_Section_5.Text != " "
                && Game.BTN_Section_9.Text != " ")
            {
                win = true;
            }
            if (Game.BTN_Section_3.Text == Game._CurrentPlayer
                && Game.BTN_Section_5.Text == Game._CurrentPlayer
                && Game.BTN_Section_7.Text == Game._CurrentPlayer
                && Game.BTN_Section_3.Text != " "
                && Game.BTN_Section_5.Text != " "
                && Game.BTN_Section_7.Text != " ")
            {
                win = true;
            }

            //if win conditions are met, display a message box and reset the game board
            if (win)
            {
                MessageBox.Show($"{Game._CurrentPlayer} Wins!");
                Game.RestBoard();
            }
            return win;
        }

        //check for draw conditions
        public static void checkDraw()
        {
            bool Draw = CheckWin();

            if(Draw == false)
            {
                if (Game.BTN_Section_1.Text == " "
                    && Game.BTN_Section_2.Text == " "
                    && Game.BTN_Section_3.Text == " "
                    && Game.BTN_Section_4.Text == " "
                    && Game.BTN_Section_5.Text == " "
                    && Game.BTN_Section_6.Text == " "
                    && Game.BTN_Section_7.Text == " "
                    && Game.BTN_Section_8.Text == " "
                    && Game.BTN_Section_9.Text == " ")
                {
                    MessageBox.Show("Draw!");
                    Game.RestBoard();
                }
            }
        }
       
    }
}
