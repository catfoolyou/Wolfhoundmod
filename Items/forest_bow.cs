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
	public class forest_bow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Forest Bow");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.DemonBow); // apply overhaul changes?
			item.shootSpeed = 50f;
			item.damage = 30;
			item.autoReuse = true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.WoodenArrowFriendly)
			{
				type = ProjectileID.CrystalLeafShot;
			}
			return true;			
		}
	}
}