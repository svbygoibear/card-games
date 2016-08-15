using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using games_common.Interfaces;
using games_common.Enums;
using System.ComponentModel;

namespace black_jack.Models {
    /// <summary>
    /// A regular playing card with french suits.
    /// </summary>
    public class FrenchCard : ICard, INotifyPropertyChanged {
        //fields 
        #region fields
        private int suitIndex;
        private int numValue;
        private int cardNameIndex;
        private FrenchSuit suit;
        private FrenchCardName cardName;
        private bool isUp;
        #endregion

        //properties
        #region properties
        public int SuitIndex {
            get { return suitIndex; }
            set { if(value != suitIndex)suitIndex = Suit != null ? (int)Suit : 0; OnPropertyChanged("SuitIndex"); }
        }

        public int NumValue {
            get { return numValue; }
            set { numValue = value; OnPropertyChanged("NumValue"); }
        }

        public int CardNameIndex {
            get { return cardNameIndex; }
            set { if (value != cardNameIndex)cardNameIndex = CardName != null ? (int)CardName : 0; OnPropertyChanged("CardNameIndex"); }
        }

        public FrenchSuit Suit {
            get { return suit; }
            set { suit = value; OnPropertyChanged("FrenchSuit"); }
        }

        public FrenchCardName CardName {
            get { return cardName; }
            set { cardName = value; OnPropertyChanged("FrenchCardName"); }
        }

        public bool IsUp {
            get { return isUp; }
            set { isUp = value; OnPropertyChanged("IsUp"); }
        }
        #endregion

        //constructor
        #region constructor
        public FrenchCard(FrenchCardName cardName, FrenchSuit suit) {
            this.CardName = cardName;
            this.Suit = suit;
            this.IsUp = true;
            this.CardNameIndex = CardName != null ? (int)CardName : 0;
            this.SuitIndex = Suit != null ? (int)Suit : 0;

        }
        #endregion

        //public methods
        #region public methods
        /// <summary>
        /// Flips the card from its current facing side
        /// </summary>
        public void Flip() {
            IsUp = !IsUp;
        }
        #endregion

        //overrides
        #region overrides
        public override string ToString() {
            char suit = '?';

            switch (this.Suit) {
                case FrenchSuit.Club:
                    suit = '♣';
                    break;
                case FrenchSuit.Diamond:
                    suit = '♦';
                    break;
                case FrenchSuit.Heart:
                    suit = '♥';
                    break;
                case FrenchSuit.Spade:
                    suit = '♠';
                    break;
            }

            return Enum.GetName(typeof(FrenchCardName), this.CardName).Substring(0, 1) + " " + suit;
        }

        public override bool Equals(object obj) {
            var regularCard = obj as FrenchCard;
            return regularCard != null && regularCard.Suit == Suit && regularCard.CardName == CardName;
        }

        public override int GetHashCode() {
            return ((int)CardName << 3) | (int)Suit;
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
