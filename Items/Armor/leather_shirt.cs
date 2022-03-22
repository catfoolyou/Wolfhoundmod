using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	
	public class leather_shirt : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Leather Shirt");
			Tooltip.SetDefault("+2% magic damage");
		}

		public override void SetDefaults() 
		{
			item.defense = 5;
			item.value = 10000;
			item.rare = 2;
		}
 		public override void UpdateEquip(Player player)
     		{
         		player.magicDamage += 0.02f;
			player.statManaMax2 += 20;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("pelt"), 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
