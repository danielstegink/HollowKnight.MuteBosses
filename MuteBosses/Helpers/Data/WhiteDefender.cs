using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for White Defender
    /// </summary>
    public class WhiteDefender : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Corpse White Defender",
            "White Defender"
        };

        public override string settingName => "WhiteDefender";

        public override List<string> miscNames => new List<string>()
        {
            "Dung Ball Large W",
        };

        public override List<string> audioSources => new List<string>()
        {
            "White Defender",
        };
    }
}