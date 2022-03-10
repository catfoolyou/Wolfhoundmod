using Terraria.ID;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using wolfhoundmod.Projectiles;

namespace wolfhoundmod.Items
{
	
	public class ElectrosphereLauncher : GlobalItem
	{
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.ElectrosphereLauncher) { // Here we make sure to only change Platinum Shortsword by checking item.type in an if statement
				item.autoReuse = true;
			}
		}
		
		
	}
}