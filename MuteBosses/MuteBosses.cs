using Modding;
using MuteBosses.Helpers;
using System.Collections.Generic;
using UnityEngine;

namespace MuteBosses
{
    public class MuteBosses : Mod, ICustomMenuMod, IGlobalSettings<GlobalSettings>
    {
        internal static MuteBosses Instance;

        public override string GetVersion() => "1.0.0.0";

        #region Global Settings
        internal static GlobalSettings globalSettings = new GlobalSettings();

        public void OnLoadGlobal(GlobalSettings s)
        {
            globalSettings = s;
        }

        public GlobalSettings OnSaveGlobal()
        {
            return globalSettings;
        }
        #endregion

        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
        {
            Log("Initializing");
            Instance = this;

            MuteHelper.ApplyHooks();

            Log("Initialized");
        }

        #region Menu Options
        public bool ToggleButtonInsideMenu => false;

        public MenuScreen GetMenuScreen(MenuScreen modListMenu, ModToggleDelegates? modToggleDelegates)
        {
            return ModMenu.CreateMenuScreen(modListMenu);
        }

        #endregion
    }
}