using Krypton.Common.Configs;
using rail;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Xenon.Content.Biomes.Somnolent;
using Xenon.Content.Items.Ammo;
using Xenon.Content.Items.DeveloperItems;

namespace Krypton.Common.Globals.KryptonPlayerGlobals
{
    [ExtendsFromMod("Xenon")]
    public class StartingGear : ModPlayer
    {
        public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
        {
            if (ModContent.GetInstance<BasicGameplayConfigs>().DevKit)
            {

                return
                [
                    new Item(ModContent.ItemType<ExoticTerraBlade>()),
                    new Item(ModContent.ItemType<ExoticDirtPickaxe>()),
                    new Item(ModContent.ItemType<ExoticPwnhammer>()),
                    new Item(ModContent.ItemType<DirtShield>()),

                    new Item(ItemID.Clentaminator2),
                    new Item(ItemID.GreenSolution, 9999),
                    new Item(ItemID.PurpleSolution, 9999),
                    new Item(ModContent.ItemType<CorrosionSolution>(), 9999),
                    new Item(ItemID.RedSolution, 9999),
                    new Item(ItemID.BlueSolution, 9999),
                    new Item(ModContent.ItemType<SnoozeSolution>(), 9999),

                    new Item(ItemID.WorldGlobe, 9999),
                ];
            }
            else if ((ModContent.GetInstance<BasicGameplayConfigs>().WorldGlobeKit))
            {
                return
                [
                new Item(ItemID.WorldGlobe, 9999)
                ];
            }
            return Enumerable.Empty<Item>();
        }
    }
}
