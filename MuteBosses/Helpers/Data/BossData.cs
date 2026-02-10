using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MuteBosses.Helpers.Data
{
    public abstract class BossData
    {
        /// <summary>
        /// Names of the bosses' object names
        /// </summary>
        public abstract List<string> bossNames { get; }

        /// <summary>
        /// Name of the setting that mutes the boss(es)
        /// </summary>
        public abstract string settingName { get; }

        /// <summary>
        /// Names of sound-making objects in the boss battle, such as minions and projectiles
        /// </summary>
        public abstract List<string> miscNames { get; }

        /// <summary>
        /// Names of objects that contain AudioSources, and therefore require additional care
        /// </summary>
        public virtual List<string> audioSources { get; } = new List<string>();

        /// <summary>
        /// Checks if the given boss is present in the scene
        /// </summary>
        /// <returns></returns>
        public bool IsBossPresent()
        {
            return UnityEngine.GameObject.FindObjectsOfType<GameObject>()
                                            .Any(x => x.activeSelf &&
                                                        bossNames.Any(y => x.name.StartsWith(y)));
        }
    }
}