using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using wolfhoundmod.Projectiles;

namespace wolfhoundmod.Items
{
	
	public class TrueNightsEdge : GlobalItem
	{
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.TrueNightsEdge) { 
				item.autoReuse = true;
			}
		}
		
		
	}
}