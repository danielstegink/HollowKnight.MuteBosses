using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Zote
    /// </summary>
    public class Zote : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Zote Boss"
        };

        public override string settingName => "Zote";

        public override List<string> miscNames => new List<string>()
        {

        };
    }
}