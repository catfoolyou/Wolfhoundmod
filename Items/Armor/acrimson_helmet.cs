using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	
	public class acrimson_helmet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ancient Crimson Helmet");
			Tooltip.SetDefault("+6% damage and increased life regen");
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