using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	
	public class steel_boots : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Steel Boots");
			Tooltip.SetDefault("+4% movement speed");
		}

		public override void SetDefaults() 
		{
			item.defense = 6;
			item.value = 10000;
			item.rare = 2;
		}
		public override void UpdateEquip(Player player)
     		{
			player.moveSpeed += 0.04f;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("steel_bar"), 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
