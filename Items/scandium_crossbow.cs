using Terraria.ID;
using Terraria.ModLoader;
using TerrariaOverhaul;

namespace wolfhoundmod.Items
{
	public class scandium_crossbow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Scandium Crossbow");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.CobaltRepeater);
			item.damage = 18;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("scandium_bar"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}