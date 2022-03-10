using Terraria.ID;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using wolfhoundmod.Projectiles;

namespace wolfhoundmod.Items
{
	
	public class TungstenShortsword : GlobalItem
	{
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.TungstenShortsword) { // Here we make sure to only change Tungsten Shortsword by checking item.type in an if statement
				item.useStyle = ItemUseStyleID.HoldingOut;
				item.useAnimation = 18;
				item.shootSpeed = 3.7f;
	
				item.melee = true;
				item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
				item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
				item.autoReuse = false; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

				item.UseSound = SoundID.Item1;
				item.shoot = ModContent.ProjectileType<Tungsten_Shortsword>();
			}
		}
		
		
	}
}