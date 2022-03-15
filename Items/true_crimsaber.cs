using wolfhoundmod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class true_crimsaber : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("True Crimsaber");
		}

		public override void SetDefaults() {
			item.damage = 90;
			item.useStyle = 1;
			item.useAnimation = 18;
			item.useTime = 30;
			item.shootSpeed = 42f;
			item.knockBack = 6.5f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = ItemRarityID.Pink;
			item.value = Item.sellPrice(gold: 5);

			item.melee = true;
			item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

			item.UseSound = SoundID.Item1;
			item.shoot = 700;
		}

		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("crimsaber"));
			recipe.AddIngredient(ItemID.SoulofMight, 20);
			recipe.AddIngredient(ItemID.SoulofSight, 20);
			recipe.AddIngredient(ItemID.SoulofFright, 20);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}