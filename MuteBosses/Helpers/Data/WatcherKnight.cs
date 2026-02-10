using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Watcher Knights
    /// </summary>
    public class WatcherKnight : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Black Knight 1",
            "Black Knight 2",
            "Black Knight 3",
            "Black Knight 4",
            "Black Knight 5",
            "Black Knight 6",
            "Corpse Black Knight",
        };

        public override string settingName => "WatcherKnight";

        public override List<string> miscNames => new List<string>()
        {
        };
    }
}