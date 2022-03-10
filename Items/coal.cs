using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
    public class coal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Coal");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 100;
            item.rare = 1;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
           
        }
    }
}