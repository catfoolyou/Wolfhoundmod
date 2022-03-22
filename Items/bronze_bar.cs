using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace wolfhoundmod.Items
{
    public class bronze_bar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bronze Bar");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 100;
            item.rare = 1;
            item.useTurn = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.bronze_bar1>();
			item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
	    recipe.AddIngredient(ItemID.CopperBar);
	    recipe.AddIngredient(ItemID.TinBar);
	    recipe.AddIngredient(mod.GetItem("coal"));
            recipe.AddTile(17);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}