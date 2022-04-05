using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace wolfhoundmod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	
	public class occultist_pants : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Occultist Cloak");
			Tooltip.SetDefault("+5% damage and increased movement speed");
		}

		public override void SetDefaults() 
		{
			item.defense = 6;
			item.value = 10000;
			item.rare = 2;
		}
		public override void UpdateEquip(Player player)
     		{
			player.allDamage += 0.05f;
			player.moveSpeed += 0.03f;
      		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShadowGreaves);
			recipe.AddIngredient(ItemID.CursedFlame);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}