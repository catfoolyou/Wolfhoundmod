using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	
	public class crimulan_chestplate : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Crimulan Chestplate");
			Tooltip.SetDefault("+5% damage and increased life regen");
		}

		public override void SetDefaults() 
		{
			item.defense = 7;
			item.value = 10000;
			item.rare = 2;
		}
 		public override void UpdateEquip(Player player)
     		{
         		player.allDamage += 0.05f;
			player.lifeRegen += 3;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimsonScalemail);
			recipe.AddIngredient(ItemID.Ichor);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}