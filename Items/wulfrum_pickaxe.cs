using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class wulfrum_pickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Wulfrum Pickaxe");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.TitaniumPickaxe);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("wulfrum_bar"), 10);
                        recipe.anyWood = true;
                        recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}