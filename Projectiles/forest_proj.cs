using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace wolfhoundmod.Projectiles
{
    public class forest_proj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forest Projectile");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.PoisonDart);
	    aiType = ProjectileID.PoisonDart;
	    projectile.friendly = false;
	    projectile.hostile = true;
        }     
    }
}