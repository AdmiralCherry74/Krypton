using Krypton.Content.Tiles;
using System;
using Terraria;
using Terraria.ModLoader;
using Xenon.Content.Tiles.ActiveAndWiring.Traps;

namespace Krypton.Common.System
{
    public class BiomeTileCounts : ModSystem 
    {
        public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts)
        {
            Main.SceneMetrics.EvilTileCount += 2500 + tileCounts[ModContent.TileType<CompactEbonstoneTile>()];
            Main.SceneMetrics.BloodTileCount += 2500 + tileCounts[ModContent.TileType<CompactCrimstoneTile>()];
            Main.SceneMetrics.HolyTileCount += 2500 + tileCounts[ModContent.TileType<CompactPearlstoneTile>()];
        }
    }
}
