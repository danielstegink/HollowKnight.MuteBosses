using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Sheo
    /// </summary>
    public class Sheo : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Sheo Boss",
            "Corpse Sheo"
        };

        public override string settingName => "Sheo";

        public override List<string> miscNames => new List<string>()
        {

        };

        public override List<string> audioSources => new List<string>()
        {
            "Paint Shot"
        };
    }
}