using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
    public class scandium_ore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scandium Ore");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 100;
            item.rare = 1;
           item.useStyle = ItemUseStyleID.SwingThrow;
		item.useTurn = true;
		item.useAnimation = 15;
		item.useTime = 10;
		item.autoReuse = true;
		item.consumable = true;
		item.createTile = ModContent.TileType<Tiles.scandium_ore1>();
		item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
           
        }
    }
}