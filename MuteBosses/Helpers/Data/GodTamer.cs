using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for God Tamer
    /// </summary>
    public class GodTamer : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Lancer",
            "Lobster",
            "Corpse Lobster",
        };

        public override string settingName => "GodTamer";

        public override List<string> miscNames => new List<string>()
        {
            "Entry Object",
            "Vomit Glob",
        };
    }
}