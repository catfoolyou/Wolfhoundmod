using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using TerrariaOverhaul;

namespace wolfhoundmod.Items
{
	public class scarab_bow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Scarab Bow");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.DemonBow); // apply overhaul changes?
			item.shootSpeed = 50f;
			item.damage = 19;
			item.autoReuse = true;
		}
	}
}