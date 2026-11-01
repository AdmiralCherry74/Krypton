using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace Krypton.Common.Configs
{
    internal class BasicGameplayConfigs : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        [Header("CharacterKits")]

        [DefaultValue(false)]
        [ReloadRequired]
        public bool DevKit;

        [DefaultValue(false)]
        [ReloadRequired]
        public bool WorldGlobeKit;
    }
}
