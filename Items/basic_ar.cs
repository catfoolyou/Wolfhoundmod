using Terraria.ID;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using wolfhoundmod.Projectiles;

namespace wolfhoundmod.Items
{
	public class basic_ar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Assault Rifle");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.Minishark);
			item.damage = 10; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			//item.useTime = 20; 
			item.useAnimation = 20; 
			item.useStyle = ItemUseStyleID.HoldingOut; 
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = 10000; 
			item.rare = ItemRarityID.Green; 
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/assaultrifle");
			item.autoReuse = true; 
			item.shoot = 10;
			//item.shootSpeed = 30f; 
			item.useAmmo = AmmoID.Bullet;
		}

		public override Vector2? HoldoutOffset()
       		{
           		return new Vector2(-10, 0);
        	}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("steel_bar"), 20);
			recipe.anyWood = true;
                        recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.Minishark, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}