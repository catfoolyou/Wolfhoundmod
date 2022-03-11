using Terraria.ID;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;

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
			item.damage = 10; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 20; 
			item.useAnimation = 20; 
			item.useStyle = ItemUseStyleID.HoldingOut; 
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = 10000; 
			item.rare = ItemRarityID.Green; 
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/shotgun");
			item.autoReuse = true; 
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f; 
			item.useAmmo = AmmoID.Bullet;
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
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // 10 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				// float scale = 1f - (Main.rand.NextFloat() * .3f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; // return false because we don't want tmodloader to shoot projectile

			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 64f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}

			int dustQuantity = 25; // How many particles do you want ?

            		for(int i = 0 ; i < dustQuantity ; i ++)

           			{

                		Vector2 dustOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 50f;
                		int dust = Dust.NewDust(player.position + dustOffset, item.width, item.height, 6); // Create the dust, "6" is the dust type (fire, in that case).
                		Main.dust[dust].noGravity = true; // Is the dust affected by gravity ?
                		Main.dust[dust].velocity *= 1f;    // Change the dust velocity.
                		Main.dust[dust].scale = 1.5f;    // Change the dust size.

           			}

			return true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("steel_bar"), 20);
			recipe.anyWood = true;
                        recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.Boomstick, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
