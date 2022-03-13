using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Projectiles
{
	public class sand_slash : ModProjectile
	{
		public override void SetStaticDefaults() {

			Main.projFrames[projectile.type] = 14;
		}

		public override void SetDefaults() {
			projectile.width = 45;
			projectile.height = 45;
			projectile.aiStyle = 20;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.hide = true;
			projectile.ownerHitCheck = true; //so you can't hit enemies through walls
			projectile.melee = true;
		}
public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
{
//3a: target.immune[projectile.owner] = 20;
//3b: target.immune[projectile.owner] = 5;
}

public override Color? GetAlpha(Color lightColor)
{
//return Color.White;
return new Color(125, 86, 56, 10) * (1f - (float)projectile.alpha / 255f);
}

public override void AI()
{
Player player = Main.player[projectile.owner]; // Cache the player that is the owner of this projectile.
Vector2 vector = player.RotatedRelativePoint(player.MountedCenter, true); // Basically a position that we can use to properly place our projectile.
// Slow down
projectile.velocity *= 1f;
// Loop through the 4 animation frames, spending 5 ticks on each.
if (++projectile.frameCounter >= 2)
{
projectile.frameCounter = 0;
if (++projectile.frame >= 14)
{
projectile.frame = 0;
}
}

projectile.direction = (projectile.spriteDirection = ((projectile.velocity.X > 0f) ? 1 : -1));
projectile.rotation = projectile.velocity.ToRotation();
if (projectile.velocity.Y > 16f)
{
projectile.velocity.Y = 16f;
}
// Since our sprite has an orientation, we need to adjust rotation to compensate for the draw flipping.
if (projectile.spriteDirection == -1)
projectile.rotation += MathHelper.Pi;
}

// Some advanced drawing because the texture image isn't centered or symetrical.
public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
{
SpriteEffects spriteEffects = SpriteEffects.None;
if (projectile.spriteDirection == -1)
{
spriteEffects = SpriteEffects.FlipHorizontally;
}
Texture2D texture = Main.projectileTexture[projectile.type];
int frameHeight = Main.projectileTexture[projectile.type].Height / Main.projFrames[projectile.type];
int startY = frameHeight * projectile.frame;
Rectangle sourceRectangle = new Rectangle(0, startY, texture.Width, frameHeight);
Vector2 origin = sourceRectangle.Size() / 2f;
origin.X = (float)((projectile.spriteDirection == 1) ? (sourceRectangle.Width - 40) : 40);

Color drawColor = projectile.GetAlpha(lightColor);
Main.spriteBatch.Draw(texture,
projectile.Center - Main.screenPosition + new Vector2(0f, projectile.gfxOffY),
sourceRectangle, drawColor, projectile.rotation, origin, projectile.scale, spriteEffects, 0f);

return false;
}
}
}
