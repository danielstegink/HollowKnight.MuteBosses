using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Radiance
    /// </summary>
    public class Radiance : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Radiance"
        };

        public override string settingName => "Radiance";

        public override List<string> miscNames => new List<string>()
        {
            "Boss Control",
            "Beam Sweeper",
            "Radiant Nail Comb",
            "Radiant Orb",
            "Tendril",
        };

        public override List<string> audioSources => new List<string>()
        {
            "Beam Sweeper"
        };
    }
}