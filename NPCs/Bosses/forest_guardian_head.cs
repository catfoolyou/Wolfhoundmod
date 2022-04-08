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

	public class forest_guardian_head : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Forest Guardian's Spirit");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults() {
			npc.aiStyle = -1;
			animationType = NPCID.Wraith;
			npc.width = 50;
            		npc.height = 50;
			npc.damage = 40;
			npc.defense = 15;
			npc.lifeMax = 4000;
			npc.boss = true;
			npc.knockBackResist = 0f;
			npc.noGravity = true;
            		npc.buffImmune[31] = true;
			npc.buffImmune[24] = true;
			npc.buffImmune[44] = true;
			npc.buffImmune[20] = true;
            		npc.noTileCollide = true;
			npc.DeathSound = SoundID.NPCDeath10;
			npc.HitSound = SoundID.NPCHit1;
			music = MusicID.Boss1;
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
				if (Timer > 60) {
				Main.PlaySound(SoundID.Roar, player.position, 0);
				npc.velocity = npc.DirectionTo(player.Center) * 10; //Ram player
				Timer = 0;
			}
		}

		public override void HitEffect(int hitDirection, double damage) {
		for (int k = 0; k < damage / npc.lifeMax * 100.0; k++) {
			Dust.NewDust(npc.position, npc.width, npc.height, 5, hitDirection, -1f, 0, default(Color), 1f);
		}
		if (npc.life <= 0)
            	{
                for (int k = 0; k < 20; k++)
                {
                    Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
                }
                	Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
                	Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
                	Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
                	Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
			Gore.NewGore(npc.position, npc.velocity, GoreID.TreeLeaf_Normal, 1f);
            	}
		
		}

		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        	{
            		npc.lifeMax = (int)(npc.lifeMax * 1.5);
            		npc.damage = (int)(npc.damage * 1.5);
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
					Item.NewItem(npc.getRect(), ModContent.ItemType<forest_blade>());
				else if(choice == 2)
					Item.NewItem(npc.getRect(), ModContent.ItemType<forest_bow>());
				else if(choice == 3)
					Item.NewItem(npc.getRect(), ModContent.ItemType<forest_staff>());
				else if(choice == 4)
					Item.NewItem(npc.getRect(), ItemID.SharkToothNecklace);
			}
		if (Main.rand.Next(1) == 0)
            		{
				/*Item.NewItem(npc.getRect(), ItemID.CrimtaneBar, Main.rand.Next(100, 150));
				Item.NewItem(npc.getRect(), ItemID.Ichor, Main.rand.Next(5, 8));*/
			}
		}


	}
}