using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using wolfhoundmod.Items;

namespace wolfhoundmod.NPCs
{
	// Forest Wolf is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class forest_mimic : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Forest Mimic");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BigMimicCorruption];
		}

		public override void SetDefaults() {
			npc.CloneDefaults(NPCID.BigMimicCorruption);
			aiType = NPCID.BigMimicCorruption;
			animationType = NPCID.BigMimicCorruption;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if(Main.hardMode && !spawnInfo.player.ZoneDungeon && !spawnInfo.player.ZoneCorrupt && !spawnInfo.player.ZoneHoly && !spawnInfo.player.ZoneMeteor && !spawnInfo.player.ZoneJungle && !spawnInfo.player.ZoneSnow && !spawnInfo.player.ZoneCrimson && !spawnInfo.player.ZoneDesert && !spawnInfo.player.ZoneGlowshroom && !spawnInfo.player.ZoneUndergroundDesert && !spawnInfo.player.ZoneBeach){
				return SpawnCondition.OverworldDaySlime.Chance * 0.5f;
			}
			else {
				return SpawnCondition.OverworldDaySlime.Chance * 0f;
			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
            		{
			int choice = Main.rand.Next(1,5);
				if(choice == 1)
					Item.NewItem(npc.getRect(), ModContent.ItemType<forest_blade>());
				else if(choice == 2)
					Item.NewItem(npc.getRect(), ModContent.ItemType<forest_bow>());
				else if(choice == 3)
					Item.NewItem(npc.getRect(), ModContent.ItemType<forest_staff>());
				else if(choice == 4)
					Item.NewItem(npc.getRect(), ItemID.SharkToothNecklace);
			}
		}

		
	}
}