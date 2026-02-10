using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Mawlek
    /// </summary>
    public class Mawlek : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Mawlek Body",
            "Mawlek Arm",
            "Mawlek Head",
            "Corpse Egg Guardian",
        };

        public override string settingName => "Mawlek";

        public override List<string> miscNames => new List<string>()
        {

        };

        public override List<string> audioSources => new List<string>()
        {
            "Shot Mawlek NoDrip"
        };
    }
}