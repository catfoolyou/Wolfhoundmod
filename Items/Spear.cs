using Terraria.ID;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using wolfhoundmod.Projectiles;

namespace wolfhoundmod.Items
{
	
	public class Spear : GlobalItem
	{
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.Spear) { // Here we make sure to only change Silver Shortsword by checking item.type in an if statement
				item.shoot = ModContent.ProjectileType<wooden_spear1>();
			}
		}
		
		
	}
}