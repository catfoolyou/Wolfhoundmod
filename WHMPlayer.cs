using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using wolfhoundmod.Items;

namespace wolfhoundmod
{

	public class WHMPlayer : ModPlayer
	{
		public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath) {
			Item item = new Item();
			item.SetDefaults(ModContent.ItemType<starter_bag>());
			item.stack = 1;
			items.Add(item);
		}
	}
}