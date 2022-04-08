using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items.Accessories
{
	[AutoloadEquip(EquipType.Shield)]

	public class eye_shield : ModItem
	{

		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Eye Shield"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10;
			item.rare = 2;
			item.defense = 2;
			item.accessory = true;
		}

		public override void UpdateEquip(Player player)
     		{
			player.noKnockback = true;
      		}
	}
}