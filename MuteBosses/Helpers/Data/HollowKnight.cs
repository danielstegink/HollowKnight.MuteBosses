using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Hollow Knight
    /// </summary>
    public class HollowKnight : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Hollow Knight Boss"
        };

        public override string settingName => "HollowKnight";

        public override List<string> miscNames => new List<string>()
        {

        };

        public override List<string> audioSources => new List<string>()
        {
            "Hollow Knight Boss",
            "Shot HK Glob",
        };
    }
}