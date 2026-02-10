using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Collector
    /// </summary>
    public class Collector : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Jar Collector"
        };

        public override string settingName => "Collector";

        public override List<string> miscNames => new List<string>()
        {

        };
    }
}