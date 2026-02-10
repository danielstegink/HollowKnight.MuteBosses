using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Lost Kin
    /// </summary>
    public class LostKin : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Lost Kin",
            "Corpse Infected Knight Dream",
        };

        public override string settingName => "BrokenVessel2";

        public override List<string> miscNames => new List<string>()
        {
            "Parasite Balloon Spawner",
        };
    }
}