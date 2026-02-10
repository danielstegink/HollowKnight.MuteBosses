using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Soul Warrior
    /// </summary>
    public class SoulWarrior : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Mage Knight",
        };

        public override string settingName => "SoulWarrior";

        public override List<string> miscNames => new List<string>()
        {
            "Mage Orb",
            "Mage Balloon Spawner",
            "Corpse Mage Balloon",
        };
    }
}