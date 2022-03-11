using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
    public class jackalope_horns : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jackalope Horns");
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
	    
        }
    }
}