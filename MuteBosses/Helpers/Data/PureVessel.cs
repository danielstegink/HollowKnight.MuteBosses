using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Pure Vessel
    /// </summary>
    public class PureVessel : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "HK Prime",
            "Corpse HK Prime"
        };

        public override string settingName => "PureVessel";

        public override List<string> miscNames => new List<string>()
        {

        };

        public override List<string> audioSources => new List<string>()
        {
            "Shot HK Shadow"
        };
    }
}