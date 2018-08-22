using System;
using Xunit;
using CashflowApp.Business.Models;

namespace CashflowApp.Test
{
    public class Game_Test
    {
        [Fact]
        public void createGameTest()
        {
            DateTime now = DateTime.Now;
            Game game = new Game(now);
            DateTime time = game.Time;
            Assert.Equal(now, time);
        }

        [Fact]
        public void createBoardTest() {
            Game game = new Game(DateTime.Now);
            Board board = game.createBoard();
            Assert.NotNull(board);
        }

        [Fact]
        public void addPlayerTest() {
            Game game = new Game(DateTime.Now);
            Player player = new Player();
            game.addPlayer(player);
            Assert.True(game.getPlayer(player));
        }

        [Fact]
        public void numberOfPlayersTest() {
            Game game = new Game(DateTime.Now);
            Player player1 = new Player();
            Player player2 = new Player();
            game.addPlayer(player1);
            game.addPlayer(player2);
            Assert.Equal(2, game.numberOfPlayers());
        }
    }
}
