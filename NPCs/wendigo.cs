using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using wolfhoundmod.Items;
using wolfhoundmod;

namespace wolfhoundmod.NPCs
{
	// wendigo is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class wendigo : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wendigo");
			Main.npcFrameCount[npc.type] = 8;
		}

		public override void SetDefaults() {
			npc.CloneDefaults(NPCID.Werewolf);
			aiType = NPCID.Werewolf;
			animationType = NPCID.GraniteGolem;
			npc.lifeMax = 150;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if(!Main.dayTime && Main.hardMode){
				return SpawnCondition.OverworldNightMonster.Chance * 0.8f;
			}
			else
			{
				return 0f;
			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(3) == 0)
            		{
				Item.NewItem(npc.getRect(), ItemID.BeamSword);
			}
			if (Main.rand.Next(10) == 0)
            		{
				Item.NewItem(npc.getRect(), ItemID.Arkhalis);
			}
			Item.NewItem(npc.getRect(), ItemID.HealingPotion, Main.rand.Next(3, 5));
			Item.NewItem(npc.getRect(), ItemID.ManaPotion, Main.rand.Next(3, 5));
			Item.NewItem(npc.getRect(), ItemID.Torch, Main.rand.Next(5, 8));
		}

		
	}
}