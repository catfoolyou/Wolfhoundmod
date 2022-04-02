using Terraria.ID;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using wolfhoundmod.Projectiles;

namespace wolfhoundmod.Items 
{
	public class vanillaedits : GlobalItem 
	{

        	public override void SetDefaults(Item item) {
			if (item.type == ItemID.BeamSword) { // Here we make sure to only change Platinum Shortsword by checking item.type in an if statement
				item.autoReuse = true;
				item.useTime = 20;
			}

			if (item.type == ItemID.ElectrosphereLauncher) { // Here we make sure to only change Platinum Shortsword by checking item.type in an if statement
				item.autoReuse = true;
			}

			if (item.type == ItemID.NightsEdge) { 
				item.autoReuse = true;
			}

			if (item.type == ItemID.OnyxBlaster) { // Here we make sure to only change Platinum Shortsword by checking item.type in an if statement
				item.autoReuse = true;
			}

			if (item.type == ItemID.Spear) { // Here we make sure to only change Silver Shortsword by checking item.type in an if statement
				item.shoot = ModContent.ProjectileType<wooden_spear1>();
			}

			if (item.type == ItemID.TrueNightsEdge) { 
				item.autoReuse = true;
			}

			if (item.type == ItemID.TrueExcalibur) { 
				item.autoReuse = true;
			}

			if (item.type == ItemID.VenusMagnum) { // Here we make sure to only change Platinum Shortsword by checking item.type in an if statement
				item.autoReuse = true;
				item.useTime = 20;
			}
			
			if (item.type == ItemID.BoneSword) { 
				item.autoReuse = true;
			}
		}

		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) {
			if (item.type == ItemID.IceBlade){
			target.AddBuff(BuffID.Frostburn, 60);
			}
			
			if (item.type == ItemID.Frostbrand){
			target.AddBuff(BuffID.Frostburn, 120);
			}
		}
	
	}
}