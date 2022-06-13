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

	public class observer : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("The Observer");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults() {
			npc.aiStyle = -1;
			animationType = NPCID.Wraith;
			npc.width = 50;
            		npc.height = 100;
			npc.damage = 34;
			npc.defense = 8;
			npc.lifeMax = 6830;
			npc.boss = true;
			npc.knockBackResist = 0f;
			npc.noGravity = true;
            		npc.buffImmune[31] = true;
			npc.buffImmune[24] = true;
			npc.buffImmune[44] = true;
			npc.buffImmune[20] = true;
            		npc.noTileCollide = true;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.HitSound = SoundID.NPCHit19;
			music = mod.GetSoundSlot(Terraria.ModLoader.SoundType.Music, "Sounds/Music/Kirbyrocket_Boss1");
		}

		public float Timer {
			get => npc.ai[0];
			set => npc.ai[0] = value;
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

			Timer++;
				if (Timer > 40) {
				Vector2 position = npc.Center;
    				Vector2 targetPosition = Main.player[npc.target].Center;
    				Vector2 direction = targetPosition - position;
    				direction.Normalize();
    				float speed = 10f;
    				int type = ProjectileID.SalamanderSpit;
    				int damage = npc.damage / 10; //If the projectile is hostile, the damage passed into NewProjectile will be applied doubled, and quadrupled if expert mode, so keep that in mind when balancing projectiles
   				Projectile.NewProjectile(position, direction * speed, type, damage, 0f, Main.myPlayer);
				Timer = 0;
			}		

           		Vector2 vector2 = new Vector2(npc.Center.X, npc.Center.Y);
            		float x = player.Center.X - vector2.X;
            		float y = player.Center.Y - vector2.Y;
            		float distance = 6f / (float)Math.Sqrt((double)x * (double)x + (double)y * (double)y);
            		float velocityX = x * distance;
            		float velocityY = y * distance;
            		npc.velocity.X = (float)(((double)npc.velocity.X * 100.0 + (double)velocityX) / 101.0);
           		npc.velocity.Y = (float)(((double)npc.velocity.Y * 100.0 + (double)velocityY) / 101.0);
            		  // code for rotation
            npc.rotation = npc.velocity.X * 0.05f;
	    npc.spriteDirection = npc.direction;
		}

		public override void HitEffect(int hitDirection, double damage) {
		for (int k = 0; k < damage / npc.lifeMax * 100.0; k++) {
			Dust.NewDust(npc.position, npc.width, npc.height, 5, hitDirection, -1f, 0, default(Color), 1f);
		}
		if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextFloat() < 0.1f) {
			Vector2 spawnAt = npc.Center + new Vector2(0f, (float)npc.height / 2f);
			NPC.NewNPC((int)spawnAt.X, (int)spawnAt.Y, NPCID.BigEater);
		}
		if (npc.life <= 0)
            	{
                for (int k = 0; k < 20; k++)
                {
                    Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
                }
                	Gore.NewGore(npc.position, npc.velocity, 29, 1f);
			Gore.NewGore(npc.position, npc.velocity, 24, 1f);
                	Gore.NewGore(npc.position, npc.velocity, 110, 1f);
			Gore.NewGore(npc.position, npc.velocity, 108, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.Sandshark1Corrupt, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.Sandshark4Corrupt, 1f);
            	}
		
		}

		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        	{
            		npc.lifeMax = (int)(npc.lifeMax * 1.5);
            		npc.damage = (int)(npc.damage * 1.5);
		}

		public override void BossLoot(ref string name, ref int potionType)
		{
    			potionType = ItemID.HealingPotion;
    			base.BossLoot(ref name, ref potionType);
		}

		public override void NPCLoot()
		{
			if (Main.expertMode)
            {
                npc.DropBossBags();
            }
			if (Main.rand.Next(1) == 0)
            		{
			int choice = Main.rand.Next(1,5);
				if(choice == 1)
					Item.NewItem(npc.getRect(), ModContent.ItemType<demonite_staff>());
				else if(choice == 2)
					Item.NewItem(npc.getRect(), ModContent.ItemType<bile_spitter>());
				else if(choice == 3)
					Item.NewItem(npc.getRect(), ItemID.NightsEdge);
				else if(choice == 4)
					Item.NewItem(npc.getRect(), ItemID.WormScarf);
			}
		if (Main.rand.Next(1) == 0)
            		{
				Item.NewItem(npc.getRect(), ItemID.DemoniteBar, Main.rand.Next(100, 150));
				Item.NewItem(npc.getRect(), ItemID.CursedFlame, Main.rand.Next(5, 8));
			}
		}
	}
}