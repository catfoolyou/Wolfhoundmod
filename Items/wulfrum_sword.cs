using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class wulfrum_sword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Wulfrum Sword");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.TitaniumSword);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("wulfrum_bar"), 10);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}