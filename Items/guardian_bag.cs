using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using wolfhoundmod.NPCs.Bosses;
using wolfhoundmod.Projectiles;
using wolfhoundmod.Items.Accessories;
using wolfhoundmod.Items;
using wolfhoundmod.Projectiles.Minions;
using wolfhoundmod.Projectiles.Minions.antlion;

namespace wolfhoundmod.Items
{
	public class guardian_bag : ModItem
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
					player.QuickSpawnItem(ModContent.ItemType<forest_blade>());
				else if(choice == 2)
					player.QuickSpawnItem(ModContent.ItemType<forest_bow>());
				else if(choice == 3)
					player.QuickSpawnItem(ModContent.ItemType<forest_staff>());
				else if(choice == 4)
					player.QuickSpawnItem(ItemID.SharkToothNecklace);
			}
		}

		public override int BossBagNPC => ModContent.NPCType<NPCs.Bosses.forest_guardian_head>();
	}
}