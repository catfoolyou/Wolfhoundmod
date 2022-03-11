using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace wolfhoundmod.Projectiles
{
    public class frost_shard1 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Shard");
        }

        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 24;
            projectile.aiStyle = 2;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.penetrate = 2;
	    aiType = ProjectileID.ThrowingKnife;
        }     

        public override bool? Colliding(Rectangle projHitbox, Rectangle targetHitbox)
        {
            if(targetHitbox.Width > 8 && targetHitbox.Height > 8)
            {
                targetHitbox.Inflate(-targetHitbox.Width / 8, -targetHitbox.Height / 8);
            }
            return projHitbox.Intersects(targetHitbox);
        }

	public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
		target.AddBuff(BuffID.Frostburn, 240); //Gives cursed flames to target for 4 seconds. (60 = 1 second, 240 = 4 seconds)
        }

	public override void OnHitPlayer(Player target, int damage, bool crit)
	{
		target.AddBuff(BuffID.Frostburn, 240, false);
	}

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 1, 1f, 0f);
            Vector2 usePos = projectile.position;
            Vector2 rotVector = (projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2();
            usePos += rotVector * 16f;

            int item = 0;
           
            if(Main.netMode == 1 && item >= 0)
            {
                NetMessage.SendData(MessageID.KillProjectile);
            }
           
            if (Main.rand.NextFloat() < 0.18f)
            {
                item = Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, ModContent.ItemType<Items.frost_shard>(), 1, false, 0, false, false);
            }
           
            if (Main.netMode == 1 && item >= 0)
            {
                NetMessage.SendData(Terraria.ID.MessageID.SyncItem, -1, -1, null, item, 1f, 0f, 0f, 0, 0, 0);
            }
        }

        private const float maxTicks = 60f;
        private const int alphaReducation = 25;

       
    }
}