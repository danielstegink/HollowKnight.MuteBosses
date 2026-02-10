using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Broken Vessel
    /// </summary>
    public class BrokenVessel : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Infected Knight",
            "Corpse Infected Knight",
        };

        public override string settingName => "BrokenVessel1";

        public override List<string> miscNames => new List<string>()
        {
            "Parasite Balloon Spawner",
        };
    }
}