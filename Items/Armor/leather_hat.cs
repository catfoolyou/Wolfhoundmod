using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	
	public class leather_hat : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Leather Hat");
			Tooltip.SetDefault("+1% summon damage and +1 max minions");
		}

		public override void SetDefaults() 
		{
			item.defense = 3;
			item.value = 10000;
			item.rare = 2;
		}

		/*public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<leather_shirt>() && legs.type == ModContent.ItemType<leather_pants>();
		}*/

		public override void UpdateEquip(Player player)
     		{
			player.minionDamage += 0.01f;
			player.maxMinions ++;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("pelt"), 6);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
