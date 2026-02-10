using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Nosk
    /// </summary>
    public class Nosk : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Mimic Spider",
            "Corpse Mimic Spider",
        };

        public override string settingName => "Nosk1";

        public override List<string> miscNames => new List<string>()
        {
        };
    }
}