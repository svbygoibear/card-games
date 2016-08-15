using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using games_common.Interfaces;
using System.ComponentModel;

namespace black_jack.Models {
    public class Hand : IHand, INotifyPropertyChanged {
        //fields
        #region fields
        private List<ICard> cards = new List<ICard>(5);
        #endregion

        //properties
        #region properties
        public List<ICard> Cards {
            get { return cards; }
            set { cards = value; OnPropertyChanged("Cards"); }
        }
        #endregion

        //constructor
        #region constructor
        public Hand(List<ICard> cards) {
            Cards = cards;
        }
        #endregion

        //public methods
        #region public methods
        public void Clear() {
            cards.Clear();
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
