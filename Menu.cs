using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace Autoplay
{
    class GnarMenu
    {
        public static Menu Menu;
        public void Init()
        {
            Menu = MainMenu.AddMenu("Gnar Reworked", "whatever", "GnarRework");
            Menu.AddGroupLabel("Loaded");
        }
    }
}