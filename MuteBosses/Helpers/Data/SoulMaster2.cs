using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Soul Tyrant
    /// </summary>
    public class SoulMaster2 : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Dream Mage Lord",
            "Dream Mage Lord Phase2",
            "Corpse Dream Mage Lord 1",
            "Corpse Dream Mage Lord 2",
            "Death Explode Boss"
        };

        public override string settingName => "SoulMaster2";

        public override List<string> miscNames => new List<string>()
        {
            "Mage Orb",
        };
    }
}