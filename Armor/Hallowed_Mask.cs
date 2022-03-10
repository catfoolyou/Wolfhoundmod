using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	
	public class Hallowed_Mask : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Hallowed Faceplate");
		}

		public override void SetDefaults() 
		{
			item.defense = 24;
			item.value = 10000;
			item.rare = 2;
		}
		public override void UpdateEquip(Player player)
     		{
			player.meleeDamage += 0.15f;
			player.rangedDamage += 0.15f;
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