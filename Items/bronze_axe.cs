using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class bronze_axe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Bronze Axe");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.axe = 60;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("bronze_bar"), 10);
                        recipe.anyWood = true;
                        recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}