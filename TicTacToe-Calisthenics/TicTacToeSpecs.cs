using System;
using System.Collections.Generic;
using Xunit;

namespace TicTacToe_Calisthenics
{
    public class TicTacToeSpecs
    {
        [Fact]
        public void game_starts_with_an_empty_board()
        {
            var expectedBoard = new string[] { String.Empty, String.Empty, String.Empty, 
                                               String.Empty, String.Empty, String.Empty, 
                                               String.Empty, String.Empty, String.Empty,
            };
            var startingBoard = new Game().Render();
            Assert.Equal(expectedBoard, startingBoard);
        }
    }

    public class Game
    {
        public IEnumerable<string> Render()
        {
            return new string[] {
                String.Empty, String.Empty, String.Empty, 
                String.Empty, String.Empty, String.Empty, 
                String.Empty, String.Empty, String.Empty,
            };
        }
    }
}
