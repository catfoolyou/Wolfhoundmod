using wolfhoundmod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class wulfrum_spear : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wulfrum Spear");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.TitaniumTrident);
			item.shoot = ModContent.ProjectileType<wulfrum_spear1>();
		}

		public override bool CanUseItem(Player player) {
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[item.shoot] < 1;
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