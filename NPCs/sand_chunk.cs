using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.NPCs
{
	// Forest Wolf is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class sand_chunk : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Sandstone Chunk");
			Main.npcFrameCount[npc.type] = 1;
		}

		public override void SetDefaults() {
			npc.CloneDefaults(NPCID.GraniteFlyer);
			aiType = NPCID.GraniteFlyer;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCHit2;
			npc.damage = 14;
			npc.defense = 6;
			npc.lifeMax = 1;
		}
		
	}
}