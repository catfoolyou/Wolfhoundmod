using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using wolfhoundmod.Items;
using wolfhoundmod.Projectiles;
using wolfhoundmod.Projectiles.Minions;
using wolfhoundmod.Projectiles.Minions.antlion;

namespace wolfhoundmod.NPCs.Bosses
{
	[AutoloadBossHead]

    public class sandlion : ModNPC
    {

	public int Timer;

	 public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Desert Guardian");
            Main.npcFrameCount[npc.type] = 5;
        }

        public override void SetDefaults()
        {
		animationType = NPCID.Wraith;
		npc.lifeMax = 2000;
		npc.damage = 12;
		npc.boss = true;
            	npc.defense = 6;
           	npc.knockBackResist = 0f;
            	npc.width = 32;
            	npc.height = 54;
            	npc.aiStyle = -1;
            	npc.npcSlots = 0.5f;
            	npc.HitSound = SoundID.NPCHit52;
            	npc.noGravity = true;
            	npc.buffImmune[31] = true;
            	npc.noTileCollide = true;
            	npc.DeathSound = SoundID.NPCDeath6;
		npc.value = Item.buyPrice(0, 0, 5, 0);
		music = MusicID.Boss1;
        }

	public override void AI(){
	    npc.TargetClosest(true);
            Player player = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || player.dead || !player.active)
            {
                npc.TargetClosest(false);
                if (npc.velocity.X > 0.0f)
                    npc.velocity.X = npc.velocity.X + 0.75f;
		
                else
                    npc.velocity.X = npc.velocity.X - 0.75f;
                npc.velocity.Y = npc.velocity.Y + 0.1f;
                if (npc.timeLeft > 10)
                {
                    npc.timeLeft = 10;
                    return;
		 }
            }
		//ModContent.ProjectileType<sand_chunk>()

            Vector2 vector2 = new Vector2(npc.Center.X, npc.Center.Y);
            float x = player.Center.X - vector2.X;
            float y = player.Center.Y - vector2.Y;
            float distance = 6f / (float)Math.Sqrt((double)x * (double)x + (double)y * (double)y);
            float velocityX = x * distance;
            float velocityY = y * distance;
            npc.velocity.X = (float)(((double)npc.velocity.X * 100.0 + (double)velocityX) / 101.0);
            npc.velocity.Y = (float)(((double)npc.velocity.Y * 100.0 + (double)velocityY) / 101.0);
            npc.rotation = (float)Math.Atan2((double)velocityY, (double)velocityX) - 0.57f; //make it less tilted
	}
	
	public override void HitEffect(int hitDirection, double damage) {
		for (int k = 0; k < damage / npc.lifeMax * 100.0; k++) {
			Dust.NewDust(npc.position, npc.width, npc.height, 5, hitDirection, -1f, 0, default(Color), 1f);
		}
		if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextFloat() < 0.1f) {
			Vector2 spawnAt = npc.Center + new Vector2(0f, (float)npc.height / 2f);
			NPC.NewNPC((int)spawnAt.X, (int)spawnAt.Y, NPCID.WalkingAntlion);
		}
		if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextFloat() < 1f) {
			Vector2 spawnAt = npc.Center + new Vector2(0f, (float)npc.height / 2f);
			NPC.NewNPC((int)spawnAt.X, (int)spawnAt.Y, ModContent.NPCType<sand_chunk>());
		}
		if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextFloat() < 0.05f) {
			Vector2 spawnAt = npc.Center + new Vector2(0f, (float)npc.height / 2f);
			NPC.NewNPC((int)spawnAt.X, (int)spawnAt.Y, NPCID.FlyingAntlion);

		}

		if (npc.life <= 0) // gore
            	{
                for (int k = 0; k < 20; k++)
                {
                    Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
                }
                Gore.NewGore(npc.position, npc.velocity, GoreID.DesertBeast1, 1f);
		Gore.NewGore(npc.position, npc.velocity, GoreID.DesertBeast2, 1f);
                Gore.NewGore(npc.position, npc.velocity, GoreID.DesertBeast3, 1f);
		Gore.NewGore(npc.position, npc.velocity, GoreID.DesertBeast4, 1f);
		Gore.NewGore(npc.position, npc.velocity, GoreID.DesertBeast1, 1f);
		Gore.NewGore(npc.position, npc.velocity, GoreID.DesertBeast2, 1f);
                Gore.NewGore(npc.position, npc.velocity, GoreID.DesertBeast3, 1f);
		Gore.NewGore(npc.position, npc.velocity, GoreID.DesertBeast4, 1f);
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
			int choice = Main.rand.Next(1,6);
				if(choice == 1)
					Item.NewItem(npc.getRect(), ModContent.ItemType<dune_splicer>());
				else if(choice == 2)
					Item.NewItem(npc.getRect(), ModContent.ItemType<sand_slasher>());
				else if(choice == 3)
					Item.NewItem(npc.getRect(), ModContent.ItemType<scarab_bow>());
				else if(choice == 4)
					Item.NewItem(npc.getRect(), ModContent.ItemType<antlion_staff>());
				else if(choice == 5)
					Item.NewItem(npc.getRect(), ModContent.ItemType<storm_spear>());
			}
		if (Main.rand.Next(1) == 0)
            		{
				Item.NewItem(npc.getRect(), ItemID.FossilOre, Main.rand.Next(10, 30));
				Item.NewItem(npc.getRect(), ItemID.Amber, Main.rand.Next(5, 8));
			}
	}
    }
}