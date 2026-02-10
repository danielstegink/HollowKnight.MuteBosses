using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Sly
    /// </summary>
    public class Sly : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Sly Boss"
        };

        public override string settingName => "Sly";

        public override List<string> miscNames => new List<string>()
        {
            "Stun Nail"
        };

        public override List<string> audioSources => new List<string>()
        {
            "Death Nail"
        };
    }
}