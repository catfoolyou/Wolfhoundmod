using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using wolfhoundmod.Items;

namespace wolfhoundmod.NPCs.Bosses
{
	[AutoloadBossHead]

    public class sandlion : ModNPC
    {
	 public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Desert Guardian");
            Main.npcFrameCount[npc.type] = 5;
        }

        public override void SetDefaults()
        {
		npc.CloneDefaults(NPCID.Vulture);
		aiType = NPCID.Vulture;
		animationType = NPCID.Wraith;
		npc.boss = true;
		npc.npcSlots = 5f;
		npc.lifeMax = 1500;
		npc.damage = 12;
		npc.defense = 9;
		npc.width = 64;
		npc.height = 64;
		npc.knockBackResist = 500f;
		npc.value = Item.buyPrice(gold: 10);
		npc.lavaImmune = true;
		npc.noTileCollide = false;
		npc.noGravity = true;
		npc.HitSound = SoundID.NPCHit44;
           	npc.DeathSound = SoundID.NPCDeath58;
		music = MusicID.Boss1;
        }
	
	public override void HitEffect(int hitDirection, double damage) {
		for (int k = 0; k < damage / npc.lifeMax * 100.0; k++) {
			Dust.NewDust(npc.position, npc.width, npc.height, 5, hitDirection, -1f, 0, default(Color), 1f);
		}
		if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextFloat() < 0.1f) {
			Vector2 spawnAt = npc.Center + new Vector2(0f, (float)npc.height / 2f);
			NPC.NewNPC((int)spawnAt.X, (int)spawnAt.Y, NPCID.WalkingAntlion);
		}
		if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextFloat() < 0.05f) {
			Vector2 spawnAt = npc.Center + new Vector2(0f, (float)npc.height / 2f);
			NPC.NewNPC((int)spawnAt.X, (int)spawnAt.Y, NPCID.FlyingAntlion);
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
			int choice = Main.rand.Next(1,4);
				if(choice == 1)
					Item.NewItem(npc.getRect(), ModContent.ItemType<dune_splicer>());
				else if(choice == 2)
					Item.NewItem(npc.getRect(), ModContent.ItemType<sand_slasher>());
				else if(choice == 3)
					Item.NewItem(npc.getRect(), ModContent.ItemType<scarab_bow>());
			}
		if (Main.rand.Next(1) == 0)
            		{
				Item.NewItem(npc.getRect(), ItemID.AncientBattleArmorMaterial, Main.rand.Next(3, 5));
			}
	}
    }
}