using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Gorb
    /// </summary>
    public class Gorb : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Ghost Warrior Slug",
            "Ghost Death Slug"
        };

        public override string settingName => "Gorb";

        public override List<string> miscNames => new List<string>()
        {

        };

        public override List<string> audioSources => new List<string>()
        {
            "Ghost Warrior Slug",
        };
    }
}