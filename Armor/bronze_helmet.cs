using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	
	public class bronze_helmet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Bronze Helmet");
		}

		public override void SetDefaults() 
		{
			item.defense = 5;
			item.value = 10000;
			item.rare = 2;
		}
		public override void UpdateEquip(Player player)
     		{
			player.minionDamage += 0.03f;
			player.maxMinions ++;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("bronze_bar"), 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
