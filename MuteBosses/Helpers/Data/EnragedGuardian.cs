using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Enraged Guardian
    /// </summary>
    public class EnragedGuardian : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Zombie Beam Miner Rematch",
            "Corpse Mega Zombie Beam Miner",
        };

        public override string settingName => "CrystalGuardian2";

        public override List<string> miscNames => new List<string>()
        {
            "Laser Turret Mega",
        };
    }
}