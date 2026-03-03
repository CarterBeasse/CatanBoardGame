using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatanBoardGame
{
    /// <summary>
    /// Central aggregate root of the domain model.
    /// Holds board state, players, bank, deck, turn information,
    /// and any derived win/award state.
    /// </summary>
    internal class GameState
    {
        // TODO: Track current active player and validate index bounds when switching turns.
        // TODO: Ensure Phase transitions follow correct turn order (Roll → Distribute → Trade → Build → End).
        // TODO: Add helper method to safely retrieve the active player.

        // TODO: Verify victory condition after every state-changing action.
        // TODO: Make sure IsGameOver locks further actions in the rules engine.
    }
}
