using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	
	public class wolf_leggings : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Wolf Fur Pants");
		}

		public override void SetDefaults() 
		{
			item.defense = 4;
			item.value = 10000;
			item.rare = 2;
		}
		public override void UpdateEquip(Player player)
     		{
			player.moveSpeed += 0.03f;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("fur"), 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
