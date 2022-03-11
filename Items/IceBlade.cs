using Terraria.ID;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using wolfhoundmod.Projectiles;

namespace wolfhoundmod.Items
{
	
	public class IceBlade : GlobalItem
	{
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) {
			if (item.type == ItemID.IceBlade){
			target.AddBuff(BuffID.Frostburn, 60);
			}
		}
		
		
	}
}