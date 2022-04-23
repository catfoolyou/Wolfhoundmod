using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using wolfhoundmod.Projectiles;

namespace wolfhoundmod.Items
{
	public class deimos : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Deimos"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			item.damage = 59;
			item.useStyle = 1;
			item.useAnimation = 18;
			item.useTime = 30;
			item.shootSpeed = 14f;
			item.knockBack = 6.5f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = ItemRarityID.Yellow;
			item.value = Item.sellPrice(gold: 10);

			item.melee = true;
			item.autoReuse = true; 

			item.UseSound = SoundID.Item1;
			item.shoot = 497;
		}

		

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5)); // 10 degree spread.
				float scale = 1f - (Main.rand.NextFloat() * .3f);
				perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; // return false because we don't want tmodloader to shoot projectile

		}		
	}
}