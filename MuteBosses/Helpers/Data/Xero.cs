using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Xero
    /// </summary>
    public class Xero : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Ghost Death Xero",
            "Ghost Warrior Xero"
        };

        public override string settingName => "Xero";

        public override List<string> miscNames => new List<string>()
        {
            "Sword",
        };
    }
}