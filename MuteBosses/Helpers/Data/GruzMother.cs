using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Gruz Mother
    /// </summary>
    public class GruzMother : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Giant Fly",
            "Corpse Big Fly 1",
        };

        public override string settingName => "GruzMother";

        public override List<string> miscNames => new List<string>()
        {
        };
    }
}