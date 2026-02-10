using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Vengefly King
    /// </summary>
    public class VengeflyKing : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Corpse Giant Buzzer Col",
            "Giant Buzzer Col"
        };

        public override string settingName => "VengeflyKing";

        public override List<string> miscNames => new List<string>()
        {

        };

        public override List<string> audioSources => new List<string>()
        {
            "Giant Buzzer Col"
        };
    }
}