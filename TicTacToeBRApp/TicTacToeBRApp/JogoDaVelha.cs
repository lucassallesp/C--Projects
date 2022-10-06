using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeBRApp
{
    internal class JogoDaVelha
    {
        static private char playerSymbol;
        static private char computerSymbol;
        static private byte[] boardState = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        static public char PlayerSymbol {get { return playerSymbol; }
            set 
            {
                char aux = Char.ToUpper(value);
                if (aux == 'O' || aux == 'X') playerSymbol = aux;
                else playerSymbol = '\0';
                ComputerSymbol = playerSymbol;
            } 
        }
        static public char ComputerSymbol { get { return computerSymbol; }
            set
            {
                if (value == 'X') computerSymbol = 'O';
                else if (value == 'O') computerSymbol = 'X';
                else computerSymbol = '\0';
            }
        }
        static public byte[] BoardState { get { return boardState; } }

        static public void markCell(byte cell,byte state)
        {
            boardState[cell] = state;
        }

        static public void clearBoard ()
        {
            for (byte i = 0; i < 9; i++) markCell(i, 0);
        }
    }
}
