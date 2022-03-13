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
			item.damage = 12;
			item.melee = true;
			item.width = 66;
			item.height = 70;
			item.useTime = 7;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 40f;
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
           		 if (Main.rand.NextBool(3)) {
               			//Emit dusts when the sword is swun
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 226, 0f, 0f, 1, default(Color), 0.5f);
            		}
       		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
	
			target.AddBuff(BuffID.Electrified, 60);
		}		
	}
}