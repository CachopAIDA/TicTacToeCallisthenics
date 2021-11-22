using System;
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
            game.Play(4);
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
            game.Play(4);
            game.Play(5);
            var resultBoard = game.Render();

            Assert.Equal(expectedBoard, resultBoard);
        }

        [Fact]
        public void throw_exception_when_position_is_occupied()
        {
            Game game = new Game();
            game.Play(4);

            Assert.Throws<InvalidOperationException>(() => game.Play(4));
        }
    }
}
