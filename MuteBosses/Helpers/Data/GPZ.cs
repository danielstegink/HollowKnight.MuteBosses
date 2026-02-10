using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Grey Prince Zote
    /// </summary>
    public class GPZ : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Grey Prince",
            "Corpse Grey Prince"
        };

        public override string settingName => "GreyPrinceZote";

        public override List<string> miscNames => new List<string>()
        {
            "Zoteling",
            "Zote Balloon",
            "Gas Explosion M",
            "Loop Charge",
        };
    }
}