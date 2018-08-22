using System;
using Xunit;
using CashflowApp.Business.Models;

namespace CashflowApp.Test
{
    public class Game_Test
    {
        [Fact]
        public void CreateGameTest()
        {
            Game game = new Game(DateTime.Now);
            DateTime time = game.getTime();
            Assert.Equal(DateTime.Now, time);
        }
    }
}
