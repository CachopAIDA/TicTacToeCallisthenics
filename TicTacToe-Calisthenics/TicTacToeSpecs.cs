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

        [Fact]
        public void first_movement_is_in_the_first_cell()
        {
            var expectedBoard = new string[]
            {
                String.Empty, String.Empty, String.Empty,
                String.Empty, "X", String.Empty,
                String.Empty, String.Empty, String.Empty,
            };

            Game game = new Game();
            game.Play();
            var resultBoard = game.Render();

            Assert.Equal(expectedBoard, resultBoard);
        }

        [Fact]
        public void second_movement_is_in_the_second_cell()
        {
            var expectedBoard = new string[]
            {
                String.Empty, String.Empty, String.Empty,
                String.Empty, "X", "O",
                String.Empty, String.Empty, String.Empty,
            };

            Game game = new Game();
            game.Play();
            game.Play();
            var resultBoard = game.Render();

            Assert.Equal(expectedBoard, resultBoard);
        }
    }

    public class Game
    {
        private string[] board = new string[] {
            String.Empty, String.Empty, String.Empty,
            String.Empty, String.Empty, String.Empty,
            String.Empty, String.Empty, String.Empty,
        };

        public IEnumerable<string> Render()
        {
            return board;
        }

        public void Play()
        {
            board = new string[]
            {
                String.Empty, String.Empty, String.Empty,
                String.Empty, "X", String.Empty,
                String.Empty, String.Empty, String.Empty,
            };
        }
    }
}
