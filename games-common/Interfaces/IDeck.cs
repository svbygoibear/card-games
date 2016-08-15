using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace games_common.Interfaces {
    /// <summary>
    /// Common interface used for decks, as decks will follow a similar structure
    /// </summary>
    public interface IDeck {
        List<ICard> Cards { get; set; } //collection of cards in the deck
    }
}
