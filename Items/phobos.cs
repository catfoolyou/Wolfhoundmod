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
	public class phobos : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Phobos");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.DemonBow); // apply overhaul changes?
			item.damage = 59;
			item.autoReuse = true;
			item.useTime = 20;
			item.shootSpeed = 15f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{

			if (type == ProjectileID.WoodenArrowFriendly)
			{
				type = 495;
			}
			return true;

			int numberProjectiles = 3;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5)); // 10 degree spread.
				float scale = 1f - (Main.rand.NextFloat() * .3f);
				perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}

	}
}