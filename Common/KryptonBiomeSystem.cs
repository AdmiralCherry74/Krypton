using Krypton.Content.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace Krypton.Common
{
    [ExtendsFromMod("Xenon")]
    public class KryptonBiomeSystem : ModSystem
    {
        public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts)
        {
            ModContent.GetInstance<Xenon.Common.Systems.BiomeTileCounts>().CorrosionTiles +=
                tileCounts[ModContent.TileType<CompactGutstoneTile>()];

            ModContent.GetInstance<Xenon.Common.Systems.BiomeTileCounts>().SomnolentTiles +=
                tileCounts[ModContent.TileType<CompactGutstoneTile>()];
        }
    }
}
