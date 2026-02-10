using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Absolute Radiance
    /// </summary>
    public class AbsRad : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Absolute Radiance"
        };

        public override string settingName => "AbsoluteRadiance";

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