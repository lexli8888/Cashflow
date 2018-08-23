using CashflowApp.Business.Models.Models;

namespace CashflowApp.Business.Models
{
    public class Player
    {
        public Player(string name) {
            _name = name;
        }

        private string _name { get; set; }
        public string Name { get { return _name; }
                            set { _name = value; }
        }

        private Piece _piece { get; set; }
        public Piece Piece { get { return _piece; }
        set { _piece = value; }
        }
    }
}