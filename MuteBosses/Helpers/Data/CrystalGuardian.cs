using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Crystal Guardian
    /// </summary>
    public class CrystalGuardian : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Mega Zombie Beam Miner",
            "Corpse Mega Zombie Beam Miner Esc",
        };

        public override string settingName => "CrystalGuardian1";

        public override List<string> miscNames => new List<string>()
        {
            "Laser Turret Mega",
        };
    }
}