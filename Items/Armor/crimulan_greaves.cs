using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	
	public class crimulan_greaves : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Crimulan Greaves");
			Tooltip.SetDefault("+5% damage and increased life regen");
		}

		public override void SetDefaults() 
		{
			item.defense = 6;
			item.value = 10000;
			item.rare = 2;
		}
		public override void UpdateEquip(Player player)
     		{
			player.allDamage += 0.05f;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimsonGreaves);
			recipe.AddIngredient(ItemID.Ichor);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}