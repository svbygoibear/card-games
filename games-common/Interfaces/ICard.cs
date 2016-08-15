using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace games_common.Interfaces {
    /// <summary>
    /// Interface used for cards, as there's different types of cards which can be defined in a deck
    /// </summary>
    public interface ICard {
        int SuitIndex { get; set; } //numeric index of the card suit
        int NumValue { get; set; } //integer value assigned to the card
        int CardNameIndex { get; set; } //the index assigned to the card name
    }
}
