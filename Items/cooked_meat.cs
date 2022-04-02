using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class cooked_meat : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cooked Meat");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 26;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item2;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = ItemRarityID.Orange;
            item.value = Item.buyPrice(silver: 10);
            item.buffType = BuffID.WellFed; //Specify an existing buff to be applied when used.
            item.buffTime = 7200; //The amount of time the buff declared in item.buffType will last in ticks. 5400 / 60 is 90, so this buff will last 90 seconds.
        }

	public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("raw_meat"));
			recipe.AddTile(17);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}