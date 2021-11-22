using System;
using System.Collections.Generic;
using Xunit.Sdk;


namespace TicTacToe_Calisthenics
{
    internal sealed class Game
    {
        private          Player player = Player.X;
        private readonly Board  board  = new Board();


        private sealed class Player
        {
            private readonly string id;

            public static Player X = new Player ( "X" );
            public static Player O = new Player( "O" );

            private Player ( string id )
            {
                this.id = id;
            }

            public override String ToString () => this.id;
        }


        internal IEnumerable<string> Render ()
        {
            return board.Render();
        }

        internal void Play ( short position )
        {
            board.Mark( position, player.ToString() );
            ChangePlayer();
        }

        private void ChangePlayer ()
        {
            player =
                    player == Player.X
                            ? Player.O
                            : Player.X;
        }

        internal string Winner ()
        {
            return player == Player.X
                    ? Player.O.ToString()
                    : Player.X.ToString();
            // return ((char) (player == Player.player1 ? Player.player2 : Player.player1)).ToString();
        }
    }
}
