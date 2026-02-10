using Satchel.BetterMenus;
using System;
using System.Linq;
using System.Reflection;

namespace MuteBosses
{
    public static class ModMenu
    {
        private static Menu menu;
        private static MenuScreen menuScreen;

        /// <summary>
        /// Builds the Exaltation Expanded menu
        /// </summary>
        /// <param name="modListMenu"></param>
        /// <returns></returns>
        public static MenuScreen CreateMenuScreen(MenuScreen modListMenu)
        {
            // Declare the menu
            menu = new Menu("Mute Bosses Options", new Element[] { });

            // Populate main menu
            menu.AddElement(new MenuButton("Toggle All",
                                "",
                                submitAction => {
                                    ToggleAll();
                                    menu.Update();
                                }));

            FieldInfo[] fields = typeof(GlobalSettings).GetFields();
            foreach (FieldInfo field in fields)
            {
                menu.AddElement(new HorizontalOption(field.Name,
                    "",
                    BoolValues(),
                    value => field.SetValue(MuteBosses.globalSettings, Convert.ToBoolean(value)),
                    () => Convert.ToInt32(field.GetValue(MuteBosses.globalSettings))));
            }

            // Insert the menu into the overall menu
            menuScreen = menu.GetMenuScreen(modListMenu);

            return menuScreen;
        }

        /// <summary>
        /// String values for boolean options
        /// </summary>
        /// <returns></returns>
        private static string[] BoolValues()
        {
            return new string[] { "DON'T MUTE", "MUTE" };
        }

        /// <summary>
        /// Toggles all settings to be the same
        /// </summary>
        private static void ToggleAll()
        {
            FieldInfo[] fields = typeof(GlobalSettings).GetFields();

            // By default, set all to false, so only set to true if all of them are false
            bool value = fields.All(x => !(bool)x.GetValue(MuteBosses.globalSettings));

            foreach (FieldInfo field in fields)
            {
                field.SetValue(MuteBosses.globalSettings, value);
            }
        }
    }
}