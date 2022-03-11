using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class crimsaber : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Crimsaber");
		}

		public override void SetDefaults() 
		{
			item.damage = 42;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 27;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BloodButcherer);
			recipe.AddIngredient(ItemID.FieryGreatsword);
			recipe.AddIngredient(ItemID.BladeofGrass);
			recipe.AddIngredient(ItemID.Muramasa);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}