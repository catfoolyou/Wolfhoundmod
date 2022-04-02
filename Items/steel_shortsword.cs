using Terraria.ID;
using wolfhoundmod.Projectiles;
using Terraria;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class steel_shortsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Steel Shortsword");
		}

		public override void SetDefaults() 
		{
           		item.rare = ItemRarityID.Blue;
            		item.value = Item.sellPrice(silver: 22);

            		item.useTime = 15;
            		item.useAnimation = 15;
            		item.useStyle = ItemUseStyleID.Stabbing;
            		item.UseSound = SoundID.Item1;
			item.autoReuse = true;

            		item.melee = true;
            		item.damage = 14;
            		item.knockBack = 1.5f;
		}
		public override bool CanUseItem(Player player) {
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[item.shoot] < 1;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("steel_bar"), 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}