using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Hornet Protector
    /// </summary>
    public class Hornet1 : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Hornet Boss 1",
            "Corpse Hornet",
        };

        public override string settingName => "Hornet1";

        public override List<string> miscNames => new List<string>()
        {
        };
    }
}