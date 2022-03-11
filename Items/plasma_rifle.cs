using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class plasma_rifle : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Plasma Rifle");
		}

		public override void SetDefaults() 
		{
			item.damage = 30; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 10; 
			item.useAnimation = 20; 
			item.useStyle = ItemUseStyleID.HoldingOut; 
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = 10000; 
			item.rare = ItemRarityID.Green; 
			item.UseSound = SoundID.Item12; 
			item.autoReuse = true; 
			item.shoot = 10;
			item.shootSpeed = 16f; 
			item.useAmmo = AmmoID.Bullet;
		}

		public override Vector2? HoldoutOffset()
       		{
           		return new Vector2(-10, 0);
        	}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
			{
				type = 440; // or ProjectileID.FireArrow;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}		

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddIngredient(ItemID.SoulofFlight, 10);
			recipe.AddIngredient(ItemID.SpaceGun, 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}