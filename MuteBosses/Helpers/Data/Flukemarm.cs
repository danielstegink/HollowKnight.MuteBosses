using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Flukemarm
    /// </summary>
    public class Flukemarm : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Fluke Mother",
            "Corpse Fluke Mother",
        };

        public override string settingName => "Flukemarm";

        public override List<string> miscNames => new List<string>()
        {
            "Spawn Point",
        };
    }
}