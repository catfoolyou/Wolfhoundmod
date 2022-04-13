using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
    public class wulfrum_bar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wulfrum Bar");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.TitaniumBar);
	    item.createTile = ModContent.TileType<Tiles.wulfrum_bar1>();
        }

        public override void AddRecipes()
        {

        }
    }
}