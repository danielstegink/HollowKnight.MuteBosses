using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Massive Moss Charger
    /// </summary>
    public class MMG : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Mega Moss Charger",
            "Corpse Mega Moss Charger",
        };

        public override string settingName => "MossCharger";

        public override List<string> miscNames => new List<string>()
        {
        };
    }
}