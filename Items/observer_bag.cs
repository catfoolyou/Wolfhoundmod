using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using wolfhoundmod.Items.Accessories;
using wolfhoundmod.Items;
using wolfhoundmod.NPCs.Bosses;
using wolfhoundmod.Projectiles;
using wolfhoundmod.Projectiles.Minions;
using wolfhoundmod.Projectiles.Minions.antlion;

namespace wolfhoundmod.Items
{
	public class observer_bag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults() {
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Cyan;
			item.expert = true;
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void OpenBossBag(Player player) {
			if (Main.rand.Next(1) == 0)
            		{
			int choice = Main.rand.Next(1,5);
				if(choice == 1)
					player.QuickSpawnItem(ModContent.ItemType<demonite_staff>());
				else if(choice == 2)
					player.QuickSpawnItem(ModContent.ItemType<bile_spitter>());
				else if(choice == 3)
					player.QuickSpawnItem(ItemID.NightsEdge);
				else if(choice == 4)
					player.QuickSpawnItem(ItemID.WormScarf);
			}
		if (Main.rand.Next(1) == 0)
            		{
				player.QuickSpawnItem(ItemID.DemoniteBar, Main.rand.Next(100, 150));
				player.QuickSpawnItem(ModContent.ItemType<eye_shield>());
				player.QuickSpawnItem(ItemID.CursedFlame, Main.rand.Next(5, 8));
			}
		}

		public override int BossBagNPC => ModContent.NPCType<NPCs.Bosses.observer>();
	}
}