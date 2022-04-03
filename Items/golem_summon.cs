using wolfhoundmod.NPCs.Bosses;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class golem_summon : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Fleshy Residue");
			Tooltip.SetDefault("Summons the Flesh Golem");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 20;
			item.rare = ItemRarityID.Green;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}

		// We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.
		public override bool CanUseItem(Player player) {
			return NPC.downedBoss2 && player.ZoneCrimson;
		}

		public override bool UseItem(Player player) {
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<NPCs.Bosses.flesh_golem>());
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TissueSample, 15);
			recipe.AddIngredient(ItemID.Vertebrae, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}