using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Mantis Lords
    /// </summary>
    public class MantisLords : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Mantis Lord",
            "Corpse Mantis Lord",
        };

        public override string settingName => "MantisLords";

        public override List<string> miscNames => new List<string>()
        {

        };

        public override List<string> audioSources => new List<string>()
        {
            "Shot Mantis Lord"
        };
    }
}