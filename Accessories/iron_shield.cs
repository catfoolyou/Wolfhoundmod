using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Accessories
{
	[AutoloadEquip(EquipType.Shield)]

	public class iron_shield : ModItem
	{

		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Iron Shield"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10;
			item.rare = 2;
			item.defense = 1;
			item.accessory = true;
		}

		public override void UpdateEquip(Player player)
     		{
			player.noKnockback = true;
      		}

		public override void AddRecipes()
       		{
            		ModRecipe recipe = new ModRecipe(mod);
			recipe.anyIronBar = true;
	   		recipe.AddIngredient((ItemID.IronBar), 20);
			recipe.anyWood = true;
                        recipe.AddIngredient(ItemID.Wood, 10);
            		recipe.AddTile(TileID.Anvils);
            		recipe.SetResult(this);
            		recipe.AddRecipe();
        	}


	}
}