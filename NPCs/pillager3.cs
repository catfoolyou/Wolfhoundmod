using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using wolfhoundmod.Items;

namespace wolfhoundmod.NPCs
{
	// pillager is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class pillager3 : ModNPC
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
			return SpawnCondition.OverworldDaySlime.Chance * 0.5f;
		}

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