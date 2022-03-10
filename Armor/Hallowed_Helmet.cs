using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	
	public class Hallowed_Helmet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Hallowed Helmet");
		}

		public override void SetDefaults() 
		{
			item.defense = 9;
			item.value = 10000;
			item.rare = 2;
		}
		public override void UpdateEquip(Player player)
     		{
			player.minionDamage += 0.15f;
			player.magicDamage += 0.15f;
			player.maxMinions += 2;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((ItemID.HallowedBar), 18);
            		recipe.AddTile(134);
            		recipe.SetResult(this);
            		recipe.AddRecipe(); 
		}
		
	}
}