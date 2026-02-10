using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Traitor Lord
    /// </summary>
    public class TraitorLord : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Mantis Traitor Lord",
            "Corpse Traitor Lord",
        };

        public override string settingName => "TraitorLord";

        public override List<string> miscNames => new List<string>()
        {

        };

        public override List<string> audioSources => new List<string>()
        {
            "Shot Traitor Lord",
        };
    }
}