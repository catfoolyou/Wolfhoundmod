using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items.Accessories
{
	public class mana_vial : ModItem
	{

		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mana vial"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("+2 mana regen and +20% magic damage");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10;
			item.rare = 2;;
			item.accessory = true;
		}

		public override void UpdateEquip(Player player)
     		{
			player.manaRegen += 4;
			player.AddBuff(BuffID.MagicPower, 2);
      		}

		public override void AddRecipes()
       		{
            		ModRecipe recipe = new ModRecipe(mod);
	   		recipe.AddIngredient(ItemID.BandofStarpower);
                        recipe.AddIngredient(ItemID.ManaCrystal);
            		recipe.AddTile(TileID.Anvils);
            		recipe.SetResult(this);
            		recipe.AddRecipe();
        	}


	}
}