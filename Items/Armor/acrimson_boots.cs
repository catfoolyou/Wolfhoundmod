using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	
	public class acrimson_boots : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ancient Crimson Greaves");
			Tooltip.SetDefault("+2% damage and increased life regen");
		}

		public override void SetDefaults() 
		{
			item.defense = 6;
			item.value = 10000;
			item.rare = 2;
		}
		public override void UpdateEquip(Player player)
     		{
			player.allDamage += 0.02f;
      		}

		public override void AddRecipes() 
		{
			
		}
		
	}
}