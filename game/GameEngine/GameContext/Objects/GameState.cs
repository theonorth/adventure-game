﻿using System.Collections.Generic;

namespace Pisces.GameEngine.GameContext.Objects
{
  internal class GameState
  {
    internal bool PastIntro { get; set; }
    internal HashSet<string> Inventory { get; set; }
    internal string CurrentRoom { get; set; }
    internal Dictionary<string, Dictionary<string, bool>> UnlockedExits { get; set; }
  }
}
