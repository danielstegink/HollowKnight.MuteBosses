using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Elder Hu
    /// </summary>
    public class ElderHu : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Ghost Warrior Hu",
            "Ghost Death Hu"
        };

        public override string settingName => "ElderHu";

        public override List<string> miscNames => new List<string>()
        {

        };

        public override List<string> audioSources => new List<string>()
        {
            "Ghost Warrior Hu",
            "Ghost Death Hu"
        };
    }
}