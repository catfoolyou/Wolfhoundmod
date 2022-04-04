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
			Tooltip.SetDefault("+3% summon damage and +1 max minions");
		}

		public override void SetDefaults() 
		{
			item.defense = 5;
			item.value = 10000;
			item.rare = 2;
		}

		/*public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<bronze_chestplate>() && legs.type == ModContent.ItemType<bronze_boots>();
		}*/

		public override void UpdateEquip(Player player)
     		{
			player.minionDamage += 0.03f;
			player.maxMinions ++;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("bronze_bar"), 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
