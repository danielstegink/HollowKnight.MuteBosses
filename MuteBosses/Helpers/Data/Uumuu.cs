using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Uumuu
    /// </summary>
    public class Uumuu : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Mega Jellyfish",
            "Corpse Mega Jellyfish",
        };

        public override string settingName => "Uumuu";

        public override List<string> miscNames => new List<string>()
        {
            "Corpse Jellyfish",
            "Lil Jellyfish",
            "Gas Explosion Uumuu",
        };
    }
}