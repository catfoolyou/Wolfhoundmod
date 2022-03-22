using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	
	public class steel_helmet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Steel Helmet");
			Tooltip.SetDefault("+2% ranged damage");
		}

		public override void SetDefaults() 
		{
			item.defense = 5;
			item.value = 10000;
			item.rare = 2;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<steel_chestplate>() && legs.type == ModContent.ItemType<steel_boots>();
		}

		public override void UpdateEquip(Player player)
     		{
			player.rangedDamage += 0.02f;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("steel_bar"), 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
