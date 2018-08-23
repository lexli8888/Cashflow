using System;
using Xunit;
using CashflowApp.Business.Models;

namespace CashflowApp.Test
{
    public class Player_Test
    {
        [Fact]
        public void createPlayerTest()
        {
            Player player = new Player("Testuser_1");
            Assert.NotNull(player);
        }

    }
}