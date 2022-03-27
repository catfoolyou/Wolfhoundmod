using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	
	public class wolf_hood : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Wolf Fur Hood");
			Tooltip.SetDefault("+1% ranged damage");
		}

		public override void SetDefaults() 
		{
			item.defense = 3;
			item.value = 10000;
			item.rare = 2;
		}

		/*public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<wolf_chestplate>() && legs.type == ModContent.ItemType<wolf_leggings>();
		}*/

		public override void UpdateEquip(Player player)
     		{
			player.rangedDamage += 0.01f;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("fur"), 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
