using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using wolfhoundmod.Items;

namespace wolfhoundmod.NPCs
{
	// Forest Wolf is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class wolf : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Forest Wolf");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Wolf];
		}

		public override void SetDefaults() {
			npc.CloneDefaults(NPCID.Wolf);
			aiType = NPCID.Wolf;
			animationType = NPCID.Wolf;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath8;
			npc.damage = 14;
			npc.defense = 6;
			npc.lifeMax = 100;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if(!spawnInfo.player.ZoneDungeon && !spawnInfo.player.ZoneCorrupt && !spawnInfo.player.ZoneHoly && !spawnInfo.player.ZoneMeteor && !spawnInfo.player.ZoneJungle && !spawnInfo.player.ZoneSnow && !spawnInfo.player.ZoneCrimson && !spawnInfo.player.ZoneDesert && !spawnInfo.player.ZoneGlowshroom && !spawnInfo.player.ZoneUndergroundDesert && !spawnInfo.player.ZoneBeach){
				return SpawnCondition.OverworldDaySlime.Chance;
			}
			else {
				return SpawnCondition.OverworldDaySlime.Chance * 0f;
			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
            		{
				Item.NewItem(npc.getRect(), ModContent.ItemType<fur>(), Main.rand.Next(5, 8));
			}
		}

		
	}
}