using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Oblobbles
    /// </summary>
    public class Oblobbles : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Mega Fat Bee"
        };

        public override string settingName => "Oblobbles";

        public override List<string> miscNames => new List<string>()
        {

        };

        public override List<string> audioSources => new List<string>()
        {
            "Oblobble Shot"
        };
    }
}