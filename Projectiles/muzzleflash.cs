using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Projectiles
{
	public class muzzleflash : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Spear");
		}

		public override void SetDefaults() {
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 19;
			projectile.penetrate = -1;
			projectile.scale = 1f;
			projectile.alpha = 0;

			projectile.hide = true;
			projectile.ownerHitCheck = true;
			projectile.melee = true;
			projectile.tileCollide = false;
			projectile.friendly = true;
		}

		
		public float movementFactor
		{
			get => projectile.ai[0];
			set => projectile.ai[0] = value;
		}

		public override void AI() {
			Player projOwner = Main.player[projectile.owner];
			// Here we set some of the projectile's owner properties, such as held item and itemtime, along with projectile direction and position based on the player
			Vector2 ownerMountedCenter = projOwner.RotatedRelativePoint(projOwner.MountedCenter, true);
			projectile.direction = projOwner.direction;
			projOwner.heldProj = projectile.whoAmI;
			projOwner.itemTime = projOwner.itemAnimation;
			projectile.position.X = ownerMountedCenter.X - (float)(projectile.width);
			projectile.position.Y = ownerMountedCenter.Y - (float)(projectile.height);
			// As long as the player isn't frozen, the spear can move
			if (!projOwner.frozen) {
				if (movementFactor == 0f) // When initially thrown out, the ai0 will be 0f
				{
					movementFactor = 4.5f; // Make sure the spear moves forward when initially thrown out
					projectile.netUpdate = true; // Make sure to netUpdate this spear
				}
			}
			// Change the spear position based off of the velocity and the movementFactor
			projectile.position += projectile.velocity * movementFactor;
			// When we reach the end of the animation, we can kill the spear projectile
			if (projOwner.itemAnimation == 0) {
				projectile.Kill();
			}
			// Apply proper rotation, with an offset of 135 degrees due to the sprite's rotation, notice the usage of MathHelper, use this class!
			// MathHelper.ToRadians(xx degrees here)
			projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(135f);
			// Offset by 90 degrees here
			if (projectile.spriteDirection == -1) {
				projectile.rotation -= MathHelper.ToRadians(90f);
			}
			
		}
	}
}