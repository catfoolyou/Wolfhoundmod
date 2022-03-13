using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class scarab_bow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Scarab Bow");
		}

		public override void SetDefaults() 
		{
			item.damage = 14;
			item.ranged = true;
			item.noMelee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 7.5f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.WoodenArrowFriendly)
			{
				type = ProjectileID.BoneDagger;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}		
	}
}