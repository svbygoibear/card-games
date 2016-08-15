using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using games_common.Interfaces;
using System.ComponentModel;

namespace black_jack.Models {
    /// <summary>
    /// Represents a player, which can be a dealer or regular player, in the game
    /// </summary>
    public class Player : IPlayer, INotifyPropertyChanged {
        //fields
        #region fields
        private string name;
        private bool isDealer;
        private IHand pHand;
        private Double bet;
        #endregion

        //properties
        #region properties
        public Double Bet {
            get { return bet; }
            set { bet = value; OnPropertyChanged("Bet"); }
        }

        public IHand PHand {
            get { return pHand; }
            set { pHand = value; OnPropertyChanged("PHand"); }
        }

        public bool IsDealer {
            get { return isDealer; }
            set { isDealer = value; OnPropertyChanged("IsDealer"); }
        }

        public string Name {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }
        #endregion

        //constructor
        #region constructor
        public Player(string playerName, bool isDealer, Hand playerHand) {
            this.Name = playerName;
            this.IsDealer = isDealer;
            this.PHand = playerHand;
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
