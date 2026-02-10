using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Oro & Mato
    /// </summary>
    public class OroMato : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Oro",
            "Mato"
        };

        public override string settingName => "OroMato";

        public override List<string> miscNames => new List<string>()
        {

        };
    }
}