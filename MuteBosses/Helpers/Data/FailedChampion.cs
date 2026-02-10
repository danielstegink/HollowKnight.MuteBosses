using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Failed Champion
    /// </summary>
    public class FailedChampion : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "False Knight Dream",
            "Death Explode Boss",
        };

        public override string settingName => "FalseKnight2";

        public override List<string> miscNames => new List<string>()
        {
            "Falling Barrel",
        };
    }
}