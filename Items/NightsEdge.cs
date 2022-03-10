using Terraria.ID;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using wolfhoundmod.Projectiles;

namespace wolfhoundmod.Items
{
	
	public class NightsEdge : GlobalItem
	{
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.NightsEdge) { 
				item.autoReuse = true;
			}
		}
		
		
	}
}