using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	
	public class acrimson_chestplate : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ancient Crimson Chestplate");
			Tooltip.SetDefault("+2% damage and increased life regen");
		}

		public override void SetDefaults() 
		{
			item.defense = 7;
			item.value = 10000;
			item.rare = 2;
		}
 		public override void UpdateEquip(Player player)
     		{
         		player.allDamage += 0.02f;
			player.lifeRegen += 2;
      		}

		public override void AddRecipes() 
		{
			
		}
		
	}
}