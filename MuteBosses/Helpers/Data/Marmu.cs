using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Marmu
    /// </summary>
    public class Marmu : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Ghost Warrior Marmu",
            "Ghost Death Marmu"
        };

        public override string settingName => "Marmu";

        public override List<string> miscNames => new List<string>()
        {

        };

        public override List<string> audioSources => new List<string>()
        {
            "Ghost Warrior Marmu",
            "Ghost Death Marmu"
        };
    }
}