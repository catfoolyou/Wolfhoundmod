using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	
	public class occultist_hood : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Occultist Hood");
			Tooltip.SetDefault("+5% damage and increased movement speed");
		}

		public override void SetDefaults() 
		{
			item.defense = 6;
			item.value = 10000;
			item.rare = 2;
		}

		/*public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<acrimson_chestplate>() && legs.type == ModContent.ItemType<acrimson_boots>();
		}*/	
	
		public override void UpdateEquip(Player player)
     		{
			player.allDamage += 0.05f;
			player.moveSpeed += 0.03f;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShadowHelmet);
			recipe.AddIngredient(ItemID.CursedFlame);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}