using System.Collections.Generic;

namespace MuteBosses.Helpers.Data
{
    /// <summary>
    /// Boss data for Winged Nosk
    /// </summary>
    public class WingedNosk : BossData
    {
        public override List<string> bossNames => new List<string>()
        {
            "Corpse Hornet Nosk",
            "Hornet Nosk"
        };

        public override string settingName => "Nosk2";

        public override List<string> miscNames => new List<string>()
        {
            "Battle Scene",
            "Parasite Balloon Spawner",
            "Glob Dropper",
        };
    }
}