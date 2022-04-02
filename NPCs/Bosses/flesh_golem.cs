using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using wolfhoundmod.Items;

namespace wolfhoundmod.NPCs.Bosses
{
	[AutoloadBossHead]

	public class flesh_golem : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Flesh Golem");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults() {
			npc.CloneDefaults(NPCID.IchorSticker);
			aiType = NPCID.IchorSticker;
			animationType = NPCID.Wraith;
			npc.width = 50;
            		npc.height = 100;
			npc.damage = 34;
			npc.defense = 8;
			npc.lifeMax = 7100;
			npc.boss = true;
			npc.knockBackResist = 0f;
			npc.noGravity = true;
            		npc.buffImmune[31] = true;
			npc.buffImmune[24] = true;
			npc.buffImmune[44] = true;
			npc.buffImmune[20] = true;
            		npc.noTileCollide = true;
			music = MusicID.Boss1;
		}

		public override void HitEffect(int hitDirection, double damage) {
		for (int k = 0; k < damage / npc.lifeMax * 100.0; k++) {
			Dust.NewDust(npc.position, npc.width, npc.height, 5, hitDirection, -1f, 0, default(Color), 1f);
		}
		if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextFloat() < 0.07f) {
			Vector2 spawnAt = npc.Center + new Vector2(0f, (float)npc.height / 2f);
			NPC.NewNPC((int)spawnAt.X, (int)spawnAt.Y, NPCID.BloodZombie);
		}
		if (npc.life <= 0)
            	{
                for (int k = 0; k < 20; k++)
                {
                    Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
                }
                	Gore.NewGore(npc.position, npc.velocity, 392, 1f);
			Gore.NewGore(npc.position, npc.velocity, 393, 1f);
                	Gore.NewGore(npc.position, npc.velocity, 400, 1f);
			Gore.NewGore(npc.position, npc.velocity, 239, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.Sandshark1Crimson, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.Sandshark4Crimson, 1f);
            	}
		
		}

		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        	{
            		npc.lifeMax = (int)(npc.lifeMax * 1.5);
            		npc.damage = (int)(npc.damage * 1.5);
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
            		{
			int choice = Main.rand.Next(1,5);
				if(choice == 1)
					Item.NewItem(npc.getRect(), ModContent.ItemType<crimson_staff>());
				else if(choice == 2)
					Item.NewItem(npc.getRect(), ModContent.ItemType<blood_bow>());
				else if(choice == 3)
					Item.NewItem(npc.getRect(), ModContent.ItemType<crimsaber>());
				else if(choice == 4)
					Item.NewItem(npc.getRect(), ItemID.BrainOfConfusion);
			}
		if (Main.rand.Next(1) == 0)
            		{
				Item.NewItem(npc.getRect(), ItemID.CrimtaneBar, Main.rand.Next(100, 150));
				Item.NewItem(npc.getRect(), ItemID.Ichor, Main.rand.Next(5, 8));
			}
		}
	}
}