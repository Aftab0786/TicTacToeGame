using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public  char X = 'X';
        public  char O = 'O';
        //UC1
        char[] board = new char[10];
        public void GameBoard()
        {
            
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }           
        }
        //UC2
        public void PlayerInput()
        {
            Console.WriteLine("Enter you Selectfrom X or O :");
            char playerChoice = Convert.ToChar(Console.ReadLine());
            if (playerChoice == 'X')
            {
                Console.WriteLine("Player select " + playerChoice);
                Console.WriteLine("Computer select " + O);
            }
            else if (playerChoice == 'O')
            {
                Console.WriteLine("Player Select " + playerChoice);
                Console.WriteLine(" Computer Select " + X);
            }
            else
            {
                Console.WriteLine("Invalid input  ");
            }
        }

    }   
}
