using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items.Accessories
{
	public class life_vial : ModItem
	{

		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Life vial"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("+2 life regen and +20% max life");
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
			player.lifeRegen += 4;
			player.AddBuff(BuffID.Lifeforce, 2);
      		}

		public override void AddRecipes()
       		{
            		ModRecipe recipe = new ModRecipe(mod);
	   		recipe.AddIngredient(ItemID.BandofRegeneration);
                        recipe.AddIngredient(ItemID.LifeCrystal);
            		recipe.AddTile(TileID.Anvils);
            		recipe.SetResult(this);
            		recipe.AddRecipe();
        	}


	}
}