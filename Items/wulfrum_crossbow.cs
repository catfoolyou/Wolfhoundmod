using Terraria.ID;
using Terraria.ModLoader;
using TerrariaOverhaul;

namespace wolfhoundmod.Items
{
	public class wulfrum_crossbow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Wulfrum Crossbow");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.TitaniumRepeater);
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