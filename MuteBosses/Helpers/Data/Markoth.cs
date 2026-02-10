using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Markoth
    /// </summary>
    public class Markoth : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Ghost Warrior Markoth",
            "Ghost Death Markoth",
        };

        public override string settingName => "Markoth";

        public override List<string> miscNames => new List<string>()
        {
            "Shot Markoth Nail"
        };
    }
}