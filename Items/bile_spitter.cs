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
	public class bile_spitter : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Bile Spitter");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.DemonBow); // apply overhaul changes?
			item.shootSpeed = 50f;
			item.damage = 21;
			item.autoReuse = true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{

			if (type == ProjectileID.WoodenArrowFriendly)
			{
				type = ProjectileID.PoisonFang;
			}
			return true;

			int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5)); // 30 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				// float scale = 1f - (Main.rand.NextFloat() * .3f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}

	}
}