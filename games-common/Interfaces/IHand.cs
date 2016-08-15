using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace games_common.Interfaces {
    /// <summary>
    /// General definition of what a hand would look like for a player in a card game
    /// </summary>
    public interface IHand {
        List<ICard> Cards { get; set; } //hand consists out of cards for each player
    }
}
