using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Xenon;
using Xenon.Content.Dusts;

namespace Krypton.Content.Tiles
{
    public class CompactEbonstoneTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            AddMapEntry(new Color(77, 53, 89));
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            TileID.Sets.Conversion.Stone[Type] = true;
            TileID.Sets.GeneralPlacementTiles[Type] = false;
            TileID.Sets.Stone[Type] = true;
            TileID.Sets.CanBeClearedDuringOreRunner[Type] = true;
            TileID.Sets.CorruptBiome[Type] += 2500;
            HitSound = SoundID.Tink;
            DustType = DustID.Corruption;
        }
    }
}
