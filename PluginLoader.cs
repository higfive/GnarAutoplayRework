﻿using EloBuddy;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace Autoplay
{
    class PluginLoader : Helper
    {
        public void LoadPlugin()
        {
            switch (myHero.Hero)
            {
                case Champion.Gnar:
                    Plugins.Gnar.Init();    
                    break;
            }
        }
    }
}