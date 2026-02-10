using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for No Eyes
    /// </summary>
    public class NoEyes : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Ghost Warrior No Eyes",
            "Ghost Death No Eyes",
        };

        public override string settingName => "NoEyes";

        public override List<string> miscNames => new List<string>()
        {

        };

        public override List<string> audioSources => new List<string>()
        {
            "Ghost Warrior No Eyes",
            "Ghost Death No Eyes",
            "No Eyes Head"
        };
    }
}