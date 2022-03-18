using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using wolfhoundmod.Items;
using wolfhoundmod.Projectiles;

namespace wolfhoundmod.NPCs.Bosses
{
	[AutoloadBossHead]

    public class mountain_king : ModNPC
    {

	public int Timer;

	 public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mountain King");
            Main.npcFrameCount[npc.type] = 4;
        }

        public override void SetDefaults()
        {
		animationType = NPCID.Wraith;
		npc.lifeMax = 3200;
		npc.damage = 20;
		npc.aiStyle = -1;
		npc.boss = true;
            	npc.defense = 12;
           	npc.knockBackResist = 0.2f;
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
	
	public override void HitEffect(int hitDirection, double damage) {
		for (int k = 0; k < damage / npc.lifeMax * 100.0; k++) {
			Dust.NewDust(npc.position, npc.width, npc.height, 5, hitDirection, -1f, 0, default(Color), 1f);
		}
		if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextFloat() < 0.2f) {
			Vector2 spawnAt = npc.Center + new Vector2(0f, (float)npc.height / 2f);
			NPC.NewNPC((int)spawnAt.X, (int)spawnAt.Y, NPCID.Salamander);
		}
		if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextFloat() < 0.1f) {
			Vector2 spawnAt = npc.Center + new Vector2(0f, (float)npc.height / 2f);
			NPC.NewNPC((int)spawnAt.X, (int)spawnAt.Y, NPCID.GraniteFlyer);

		}
		
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
       
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 1.5);
            npc.damage = (int)(npc.damage * 1.5);
	}

        public override void NPCLoot()
        {
       		
	}
    }
}