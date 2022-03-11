using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
    public class pelt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pelt");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 100;
            item.rare = ItemRarityID.Green;
        }

        public override void AddRecipes()
        {
	    ModRecipe recipe = new ModRecipe(mod);
	    recipe.AddIngredient(mod.GetItem("fur"), 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}