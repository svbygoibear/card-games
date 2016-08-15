using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace games_common.Interfaces {
    /// <summary>
    /// General definition of what a player should look like in a card game.
    /// </summary>
    public interface IPlayer {
        string Name { get; set; } //name of the player
        bool IsDealer { get; set; } //indicates if the player is the dealer or not
        IHand PHand { get; set; } //hand of the player
        
    }
}
