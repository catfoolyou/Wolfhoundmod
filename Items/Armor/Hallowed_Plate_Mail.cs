using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	
	public class Hallowed_Plate_Mail : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Hallowed Plate Mail");
			Tooltip.SetDefault("+7% damage and +2 HP/S life regen");
		}

		public override void SetDefaults() 
		{
			item.defense = 15;
			item.value = 10000;
			item.rare = 2;
		}
 		public override void UpdateEquip(Player player)
     		{
         		player.allDamage += 0.07f;
			player.lifeRegen += 12;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((ItemID.HallowedBar), 24);
            		recipe.AddTile(134);
            		recipe.SetResult(this);
            		recipe.AddRecipe(); 
		}
		
	}
}