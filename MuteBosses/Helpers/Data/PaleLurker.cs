using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Pale Lurker
    /// </summary>
    public class PaleLurker : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Pale Lurker"
        };

        public override string settingName => "PaleLurker";

        public override List<string> miscNames => new List<string>()
        {

        };
    }
}