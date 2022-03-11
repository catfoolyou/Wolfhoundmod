using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class steel_crossbow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Steel Crossbow");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.ranged = true;
			item.noMelee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 7.5f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("steel_bar"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}