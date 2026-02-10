using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Soul Master
    /// </summary>
    public class SoulMaster1 : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Mage Lord",
            "Mage Lord Phase2",
            "Corpse Mage Lord 1",
            "Death Explode Boss",
            "Corpse Mage Lord 2",
        };

        public override string settingName => "SoulMaster1";

        public override List<string> miscNames => new List<string>()
        {
            "Mage Orb",
        };
    }
}