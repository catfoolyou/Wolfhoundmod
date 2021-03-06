using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using wolfhoundmod.Items;
using wolfhoundmod;

namespace wolfhoundmod.NPCs
{
	// pillager is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class pillager : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pillager");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults() {
			npc.CloneDefaults(NPCID.Skeleton);
			aiType = NPCID.Skeleton;
			animationType = NPCID.Zombie;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.lifeMax = 120;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if(!spawnInfo.player.ZoneDungeon && !spawnInfo.player.ZoneCorrupt && !spawnInfo.player.ZoneHoly && !spawnInfo.player.ZoneMeteor && !spawnInfo.player.ZoneJungle && !spawnInfo.player.ZoneSnow && !spawnInfo.player.ZoneCrimson && !spawnInfo.player.ZoneDesert && !spawnInfo.player.ZoneGlowshroom && !spawnInfo.player.ZoneUndergroundDesert && !spawnInfo.player.ZoneBeach){
				return SpawnCondition.OverworldDaySlime.Chance;
			}
			else {
				return SpawnCondition.OverworldDaySlime.Chance * 0f;
			}
		}

		/*public override void HitEffect(int hitDirection, double damage) {
			if (npc.life <= 0)
            		{
				Main.NewText("You killed a pillager, you pay the price...", 175, 75, 255, false);
				Raid.StartRaid();
				return true;
			}
		}*/

		public override void NPCLoot()
		{
			if (Main.rand.Next(3) == 0)
            		{
				Item.NewItem(npc.getRect(), ItemID.IronBroadsword);
			}
			if (Main.rand.Next(10) == 0)
            		{
				Item.NewItem(npc.getRect(), mod.ItemType("terragrim"));
			}
			Item.NewItem(npc.getRect(), ItemID.LesserHealingPotion, Main.rand.Next(3, 5));
			Item.NewItem(npc.getRect(), ItemID.LesserManaPotion, Main.rand.Next(3, 5));
			Item.NewItem(npc.getRect(), ItemID.Torch, Main.rand.Next(5, 8));
		}

		
	}
}