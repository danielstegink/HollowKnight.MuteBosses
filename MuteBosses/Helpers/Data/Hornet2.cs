using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Hornet Sentinel
    /// </summary>
    public class Hornet2 : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Hornet Boss 2",
            "Corpse Hornet",
        };

        public override string settingName => "Hornet2";

        public override List<string> miscNames => new List<string>()
        {
            "Hornet Barb",
        };
    }
}