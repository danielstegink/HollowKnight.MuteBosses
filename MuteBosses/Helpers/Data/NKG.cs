using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Nightmare King Grimm
    /// </summary>
    public class NKG : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Nightmare Grimm Boss",
            "Heartbeat Audio",
            "Grimm Control",
        };

        public override string settingName => "NightmareKingGrimm";

        public override List<string> miscNames => new List<string>()
        {
            "Grimm_flare_pillar",
            "Grimm Spike Holder",
        };
    }
}