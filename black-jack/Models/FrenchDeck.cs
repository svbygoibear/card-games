using System;
using System.Collections.Generic;
using System.Linq;
using games_common.Interfaces;
using games_common.Enums;
using System.Security.Cryptography;
using System.ComponentModel;

namespace black_jack.Models {
    /// <summary>
    /// Deck of 52 cards including the french suits.
    /// </summary>
    public class FrenchDeck : IDeck, INotifyPropertyChanged {
        //fields
        #region fields
        private List<ICard> cards;
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
        public FrenchDeck() {
            cards = new List<ICard>(52);
            CreateDeck();
        }
        #endregion

        //public methods
        #region public methods
        /// <summary>
        /// Creates a new deck
        /// </summary>
        public void CreateDeck() {
            cards.Clear();
            cards.AddRange(
                Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 13).Select(n => new FrenchCard((FrenchCardName)n, (FrenchSuit)s))));
        }

        /// <summary>
        /// Shuffles an existing deck.
        /// </summary>
        //ToDo: Remove while loop and replace with recursive function
        public void Shuffle() {
            var i = cards.Count;
            var rng = new RNGCryptoServiceProvider();

            while (i > 1) {
                var buffer = new byte[8];
                rng.GetBytes(buffer);
                var j = (int)(BitConverter.ToUInt64(buffer, 0) % (ulong)cards.Count); //generates a random number

                i--;
                var temp = cards[j];
                cards[j] = cards[i];
                cards[i] = temp;
            }
        }

        public void DealHand() {
        }

        public void DealCard() {
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
