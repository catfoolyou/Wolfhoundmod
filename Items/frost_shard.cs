using wolfhoundmod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class frost_shard : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Frost Shard");
		}

		public override void SetDefaults() {
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 10f;
			item.damage = 15;
			item.knockBack = 5f;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 25;
			item.useTime = 25;
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
			item.rare = ItemRarityID.Blue;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 5);
			// Look at the javelin projectile for a lot of custom code
			// If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
			item.shoot = ModContent.ProjectileType<frost_shard1>();
		
		}
		public override void AddRecipes()
        		{
	    			ModRecipe recipe = new ModRecipe(mod);
	    			recipe.AddIngredient(ItemID.ThrowingKnife);
	    			recipe.AddIngredient(ItemID.IceBlock);
            			recipe.AddTile(TileID.WorkBenches);
            			recipe.SetResult(this);
            			recipe.AddRecipe();
        		}
	}
}