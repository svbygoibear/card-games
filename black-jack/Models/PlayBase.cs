using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace black_jack.Models {
    public class PlayBase: INotifyPropertyChanged {
        //fields
        #region fields
        private List<Player> players;
        #endregion

        //properties
        #region properties
        public List<Player> Players {
            get { return players; }
            set { players = value; OnPropertyChanged("Players"); }
        }
        #endregion

        //constructor
        #region constructor
        public PlayBase(List<Player> players) {
            Players = players;
        }
        #endregion

        //public methods
        #region public methods
        public List<Player> CurrentWinners() {
            List<Player> winners = new List<Player>();
            int winVal = 0;
            var sortedPlayers = Players.OrderBy(p => p.HandTotal).ToList();

            sortedPlayers.Reverse();
            sortedPlayers.ForEach(player => {
                if (player.HandTotal >= winVal && player.HandTotal <= 21) {
                    winVal = player.HandTotal;
                    winners.Add(player);
                }
            });
            return winners;
        }
        #endregion

        //property changed
        #region property changed
        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
