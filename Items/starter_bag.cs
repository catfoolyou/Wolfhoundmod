using wolfhoundmod.Items;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace wolfhoundmod.Items
{
	public class starter_bag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Starter Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults() {
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Blue;
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void RightClick(Player player) { // OpenBossBag
			player.QuickSpawnItem(ItemID.TinBroadsword);
			player.QuickSpawnItem(ItemID.WoodenBow);
			player.QuickSpawnItem((ItemID.WoodenArrow), 100);
			player.QuickSpawnItem(ItemID.TopazStaff);
			player.QuickSpawnItem(ItemID.LifeCrystal);
			player.QuickSpawnItem((ItemID.ManaCrystal), 2);
			player.QuickSpawnItem((ItemID.RecallPotion), 5);
			player.QuickSpawnItem(ItemID.FamiliarWig);
			player.QuickSpawnItem(ItemID.FamiliarShirt);
			player.QuickSpawnItem(ItemID.FamiliarPants);
		}
	}
}