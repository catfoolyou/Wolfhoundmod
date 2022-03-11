using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	
	public class steel_chestplate : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Steel Chestplate");
			Tooltip.SetDefault("+3% melee damage");
		}

		public override void SetDefaults() 
		{
			item.defense = 7;
			item.value = 10000;
			item.rare = 2;
		}
 		public override void UpdateEquip(Player player)
     		{
         		player.meleeDamage += 0.03f;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("steel_bar"), 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
