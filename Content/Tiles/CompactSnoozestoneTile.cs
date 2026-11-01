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
using Xenon.Common.Systems;
using Xenon.Content.Dusts;

namespace Krypton.Content.Tiles
{
    public class CompactSnoozestoneTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            AddMapEntry(new Color(127, 106, 0));
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            TileID.Sets.Conversion.Stone[Type] = true;
            TileID.Sets.GeneralPlacementTiles[Type] = false;
            TileID.Sets.Stone[Type] = true;
            TileID.Sets.CanBeClearedDuringOreRunner[Type] = true;
            HitSound = SoundID.Tink;
            DustType = DustID.BlueMoss;
        }
    }
}
