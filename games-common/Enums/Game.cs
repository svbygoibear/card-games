using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace games_common.Enums {
    /// <summary>
    /// Current state of the game
    /// </summary>
    public enum GState {
        Unknown,
        PlayerWon,
        DealerWon,
        Draw
    }
}
