using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Galien
    /// </summary>
    public class Galien : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Ghost Warrior Galien",
            "Ghost Death Galien",
        };

        public override string settingName => "Galien";

        public override List<string> miscNames => new List<string>()
        {
            "Galien Hammer",
        };
    }
}