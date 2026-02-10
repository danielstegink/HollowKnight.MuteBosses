using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Dung Defender
    /// </summary>
    public class DungDefender : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Dung Defender",
            "Corpse Dung Defender",
        };

        public override string settingName => "DungDefender";

        public override List<string> miscNames => new List<string>()
        {
            "Dung Ball Large",
        };

        public override List<string> audioSources => new List<string>()
        {
            "Dung Defender",
        };
    }
}