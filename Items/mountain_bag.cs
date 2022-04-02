using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using wolfhoundmod.NPCs.Bosses;

namespace wolfhoundmod.Items
{
	public class mountain_bag : ModItem
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
					player.QuickSpawnItem(ItemID.BoneSword);
				else if(choice == 2)
					player.QuickSpawnItem(ItemID.BonePickaxe);
				else if(choice == 3)
					player.QuickSpawnItem(ItemID.MagicLantern);
				else if(choice == 4)
					player.QuickSpawnItem(ItemID.ChainKnife);
			}
		if (Main.rand.Next(1) == 0)
            		{
				player.QuickSpawnItem(ModContent.ItemType<scandium_ore>(), Main.rand.Next(100, 150));
				player.QuickSpawnItem(ItemID.Amethyst, Main.rand.Next(5, 8));
			}
		if (Main.rand.Next(10) == 0)
            		{
				player.QuickSpawnItem(ItemID.Arkhalis);
			}
		}

		public override int BossBagNPC => ModContent.NPCType<NPCs.Bosses.mountain_king>();
	}
}