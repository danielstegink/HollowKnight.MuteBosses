using MuteBosses.Helpers.Data;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace MuteBosses.Helpers
{
    public static class MuteHelper
    {
        /// <summary>
        /// Repository of boss data
        /// </summary>
        public static List<BossData> bossData = new List<BossData>()
        {
            new AbsRad(),
            new BrokenVessel(),
            new Collector(),
            new CrystalGuardian(),
            new DungDefender(),
            new ElderHu(),
            new EnragedGuardian(),
            new FailedChampion(),
            new FalseKnight(),
            new Flukemarm(),
            new Galien(),
            new GodTamer(),
            new Gorb(),
            new GPZ(),
            new Grimm(),
            new GruzMother(),
            new HiveKnight(),
            new HollowKnight(),
            new Hornet1(),
            new Hornet2(),
            new LostKin(),
            new MantisLords(),
            new Markoth(),
            new Marmu(),
            new Mawlek(),
            new MMG(),
            new NKG(),
            new NoEyes(),
            new Nosk(),
            new Oblobbles(),
            new OroMato(),
            new PaleLurker(),
            new PureVessel(),
            new Radiance(),
            new Sheo(),
            new Sly(),
            new SoulMaster1(),
            new SoulMaster2(),
            new SoulWarrior(),
            new TraitorLord(),
            new Uumuu(),
            new VengeflyKing(),
            new WatcherKnight(),
            new WhiteDefender(),
            new WingedNosk(),
            new Xero(),
        };

        public static void ApplyHooks()
        {
            On.HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle.DoPlayRandomClip += MuteOneShotSingle;
            On.HutongGames.PlayMaker.Actions.AudioPlayerOneShot.DoPlayRandomClip += MuteOneShot;
            On.HutongGames.PlayMaker.Actions.AudioPlaySimple.OnEnter += MuteSimple;
            On.HutongGames.PlayMaker.Actions.AudioPlayInState.OnEnter += MuteInState;
            On.HutongGames.PlayMaker.Actions.AudioPlayRandom.OnEnter += MuteRandom;

            On.HeroController.Update += MuteAudioSources;
        }

        #region Mute Fsm
        private static void MuteOneShotSingle(On.HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle.orig_DoPlayRandomClip orig,
                                                HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle self)
        {
            float volume = self.volume.Value;
            if (ShouldMute(self.Fsm.GameObjectName) ||
                MuteTraitorDeath(self) ||
                MuteHKScream(self))
            {
                //MuteBosses.Instance.Log($"AudioPlayerOneShotSingle - Muting {self.Fsm.GameObjectName} ({fieldName})");
                self.volume.Value = 0f;
            }
            //else
            //{
            //    MuteBosses.Instance.Log($"AudioPlayerOneShotSingle - Not muting {self.Fsm.GameObjectName}");
            //}

            orig(self);

            // Remember to reset afterwards
            self.volume.Value = volume;
        }

        /// <summary>
        /// Custom case to check for the Traitor Lord's explosive death
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        private static bool MuteTraitorDeath(HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle self)
        {
            return MuteBosses.globalSettings.InfectionDeathExplosion &&
                    self.Fsm.GameObjectName.StartsWith("Corpse Traitor Lord");
        }

        /// <summary>
        /// Custom case to check for the Hollow Knight's initial scream
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        private static bool MuteHKScream(HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle self)
        {
            return MuteBosses.globalSettings.HollowKnight &&
                    self.Fsm.GameObjectName.Equals("Boss Control") &&
                    self.State.Name.Equals("Roar");
        }

        private static void MuteOneShot(On.HutongGames.PlayMaker.Actions.AudioPlayerOneShot.orig_DoPlayRandomClip orig,
                                        HutongGames.PlayMaker.Actions.AudioPlayerOneShot self)
        {
            float volume = self.volume.Value;
            if (ShouldMute(self.Fsm.GameObjectName))
            {
                //MuteBosses.Instance.Log($"AudioPlayerOneShot - Muting {self.Fsm.GameObjectName} ({fieldName})");
                self.volume.Value = 0f;
            }
            //else
            //{
            //    MuteBosses.Instance.Log($"AudioPlayerOneShot - Not muting {self.Fsm.GameObjectName}");
            //}

            orig(self);

            // Remember to reset afterwards
            self.volume.Value = volume;
        }

        private static void MuteSimple(On.HutongGames.PlayMaker.Actions.AudioPlaySimple.orig_OnEnter orig,
                                        HutongGames.PlayMaker.Actions.AudioPlaySimple self)
        {
            float volume = self.volume.Value;
            if (ShouldMute(self.Fsm.GameObjectName))
            {
                //MuteBosses.Instance.Log($"AudioPlaySimple - Muting {self.Fsm.GameObjectName} ({fieldName})");
                self.volume.Value = 0f;
            }
            //else
            //{
            //    MuteBosses.Instance.Log($"AudioPlaySimple - Not muting {self.Fsm.GameObjectName}");
            //}

            orig(self);

            // Remember to reset afterwards
            self.volume.Value = volume;
        }

        private static void MuteInState(On.HutongGames.PlayMaker.Actions.AudioPlayInState.orig_OnEnter orig,
                                        HutongGames.PlayMaker.Actions.AudioPlayInState self)
        {
            float volume = self.volume.Value;
            if (ShouldMute(self.Fsm.GameObjectName))
            {
                //MuteBosses.Instance.Log($"AudioPlayInState - Muting {self.Fsm.GameObjectName} ({fieldName})");
                self.volume.Value = 0f;
            }
            //else
            //{
            //    MuteBosses.Instance.Log($"AudioPlayInState - Not muting {self.Fsm.GameObjectName}");
            //}

            orig(self);

            // Remember to reset afterwards
            self.volume.Value = volume;
        }

        private static void MuteRandom(On.HutongGames.PlayMaker.Actions.AudioPlayRandom.orig_OnEnter orig,
                                        HutongGames.PlayMaker.Actions.AudioPlayRandom self)
        {
            AudioClip[] audioClips = self.audioClips;
            if (ShouldMute(self.Fsm.GameObjectName))
            {
                //MuteBosses.Instance.Log($"AudioPlayRandom - Muting {self.Fsm.GameObjectName} ({fieldName})");
                self.audioClips = new AudioClip[] { };
            }
            //else
            //{
            //    MuteBosses.Instance.Log($"AudioPlayRandom - Not muting {self.Fsm.GameObjectName}");
            //}

            orig(self);

            // Remember to reset afterwards
            self.audioClips = audioClips;
        }

        /// <summary>
        /// Checks if the given game object should be muted
        /// </summary>
        /// <param name="gameObjectName"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        private static bool ShouldMute(string gameObjectName)
        {
            foreach (BossData data in bossData)
            {
                // First, check if the boss' setting is set to Mute
                FieldInfo setting = typeof(GlobalSettings).GetField(data.settingName);
                if (!(bool)setting.GetValue(MuteBosses.globalSettings))
                {
                    continue;
                }

                // Then, check if this object matches the given boss(es)
                if (!data.bossNames.Any(x => gameObjectName.StartsWith(x)) &&
                    !data.miscNames.Any(x => gameObjectName.StartsWith(x)))
                {
                    continue;
                }

                // Finally, check if the given boss is active
                if (data.IsBossPresent())
                {
                    return true;
                }
            }

            return false;
        }
        #endregion

        /// <summary>
        /// Mutes audio sources coming from certain bosses
        /// </summary>
        /// <param name="orig"></param>
        /// <param name="self"></param>
        private static void MuteAudioSources(On.HeroController.orig_Update orig, HeroController self)
        {
            orig(self);
            AudioSource[] audioSources = UnityEngine.Object.FindObjectsOfType<AudioSource>();

            // Zote
            AudioSource[] bossSources = audioSources.Where(x => x.gameObject.name.StartsWith("Zote")).ToArray();
            foreach (AudioSource audioSource in bossSources)
            {
                audioSource.mute = MuteBosses.globalSettings.Zote;
            }

            // Infection death explosions
            List<string> explosionSources = new List<string>()
            {
                "Death Explode Boss",
                "Corpse Mimic Spider",
                "Corpse Hornet Nosk",
                "Corpse Fluke Mother",
            };
            bossSources = audioSources.Where(x => explosionSources.Any(y => x.gameObject.name.StartsWith(y))).ToArray();
            foreach (AudioSource audioSource in bossSources)
            {
                audioSource.mute = MuteBosses.globalSettings.InfectionDeathExplosion;
            }

            // Bosses
            foreach (BossData data in bossData)
            {
                FieldInfo setting = typeof(GlobalSettings).GetField(data.settingName);
                foreach (string sourceObject in data.audioSources)
                {
                    bossSources = audioSources.Where(x => x.gameObject.name.StartsWith(sourceObject)).ToArray();
                    foreach (AudioSource audioSource in bossSources)
                    {
                        audioSource.mute = (bool)setting.GetValue(MuteBosses.globalSettings);
                    }
                }
            }
        }
    }
}