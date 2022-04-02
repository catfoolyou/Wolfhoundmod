using Terraria.ID;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using TerrariaOverhaul;

namespace wolfhoundmod.Items
{
	public class shotgun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Double Barrel Shotgun");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.TacticalShotgun);
			item.damage = 15;
			item.shootSpeed = 42f;
		}

		public override Vector2? HoldoutOffset()
       		{
           		return new Vector2(-10, 0);
        	}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5)); // 30 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				// float scale = 1f - (Main.rand.NextFloat() * .3f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; // return false because we don't want tmodloader to shoot projectile
		}
	
		public override void AddRecipes() 
		{
			/*ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("steel_bar"), 20);
			recipe.anyWood = true;
                        recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.Boomstick, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();*/
		}
		
	}
}
