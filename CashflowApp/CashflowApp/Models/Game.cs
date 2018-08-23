using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CashflowApp.Business.Models
{
    public class Game

    {
        private DateTime _time { get; set; }
        private List<Player> _players { get; set; }
        private Board _board { get; set; }

        public DateTime Time { get { return _time; }
            set { _time = value; }
        }

        public Game(DateTime time) {
            _time = time;
            _players = new List<Player>();
            _board = createBoard();
        }


        public Board createBoard()
        {
            return new Board();
        }

        public void addPlayer(Player player)
        {
            _players.Add(player);
        }

        public bool getPlayer(Player player)
        {
            return _players.Contains(player);
        }

        public ReadOnlyCollection<Player> getPlayers() {
            return new ReadOnlyCollection<Player>(this._players);
        }

        public int numberOfPlayers() {
            return _players.Count;
        }

        public TimeSpan duration() {
            return DateTime.Now - Time;
        }

        public void start()
        {
            throw new NotImplementedException();
        }
    }
}
