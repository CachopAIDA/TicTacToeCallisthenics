using System;
using System.Collections.Generic;
using Xunit;

namespace TicTacToe_Calisthenics
{
    public class TicTacToeSpecs
    {
        private IEnumerable<object> winnerExpected;

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

        [Fact]
        public void after_five_movement_playerX_wins_game()
        {
            var winnerExpected = "X";

            Game game = new Game();
            game.Play(4);
            game.Play(0);
            game.Play(5);
            game.Play(8);
            game.Play(3);

            Assert.Equal(winnerExpected, game.Winner());
        }

        [Fact]
        public void after_six_movement_playerO_wins_game()
        {
            var winnerExpected = "O";

            Game game = new Game();
            game.Play(4);
            game.Play(0);
            game.Play(5);
            game.Play(1);
            game.Play(6);
            game.Play(2);

            Assert.Equal(winnerExpected, game.Winner());
        }
    }
}
