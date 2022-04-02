using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using wolfhoundmod.Projectiles;

namespace wolfhoundmod.Items
{
	public class sand_slasher : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Storm Slasher"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			item.damage = 15;
			item.useStyle = 1;
			item.useAnimation = 18;
			item.useTime = 30;
			item.shootSpeed = 14f;
			item.knockBack = 6.5f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = ItemRarityID.Green;
			item.value = Item.sellPrice(gold: 5);

			item.melee = true;
			item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

			item.UseSound = SoundID.Item1;
			item.shoot = 660;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
	
			target.AddBuff(BuffID.Electrified, 240);
		}		
	}
}