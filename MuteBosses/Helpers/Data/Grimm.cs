using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Grimm
    /// </summary>
    public class Grimm : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Grimm Boss"
        };

        public override string settingName => "Grimm";

        public override List<string> miscNames => new List<string>()
        {
            "Grimm Scene",
            "Grimm Spike Holder",
        };
    }
}