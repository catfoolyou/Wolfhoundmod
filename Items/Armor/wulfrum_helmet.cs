using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	
	public class wulfrum_helmet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Wulfrum Helmet");
			Tooltip.SetDefault("+10% damage and increased life regen");
		}

		public override void SetDefaults() 
		{
			item.defense = 23;
			item.value = 10000;
			item.rare = 2;
		}

		/*public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<acrimson_chestplate>() && legs.type == ModContent.ItemType<acrimson_boots>();
		}*/	
	
		public override void UpdateEquip(Player player)
     		{
			player.allDamage += 0.1f;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("wulfrum_bar"), 13);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}