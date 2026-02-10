using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for False Knight
    /// </summary>
    public class FalseKnight : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "False Knight New",
            "Death Explode Boss",
        };

        public override string settingName => "FalseKnight1";

        public override List<string> miscNames => new List<string>()
        {
            "Falling Barrel",
        };
    }
}