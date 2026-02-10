using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Hive Knight
    /// </summary>
    public class HiveKnight : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Hive Knight",
            "Corpse Hive Knight",
        };

        public override string settingName => "HiveKnight";

        public override List<string> miscNames => new List<string>()
        {
            "Hive Knight Glob",
        };
    }
}