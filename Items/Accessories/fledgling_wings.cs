using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]

	public class fledgling_wings : ModItem
	{

		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Fledgling wings");
			 Tooltip.SetDefault("Allows flight and slow fall");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 57; //wings Height
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 1f;
			constantAscend = 0.18f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 10f;
			acceleration *= 2.6f;
		}

	}
}