using Microsoft.Xna.Framework;
using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using wolfhoundmod.Items;

namespace wolfhoundmod.NPCs
{
	
	internal class jackalope : ModNPC
	{

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Jackalope");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Bunny];
			Main.npcCatchable[npc.type] = true;
		}

		public override void SetDefaults() {
			

			npc.CloneDefaults(NPCID.Bunny);
			npc.catchItem = (short)ModContent.ItemType<jackalopeItem>();
			npc.lavaImmune = true;
			
			npc.friendly = true; 
			aiType = NPCID.Bunny;
			animationType = NPCID.Bunny;
		}
		public override void NPCLoot()
		{
			if (Main.rand.Next(2) == 0)
            		{
				Item.NewItem(npc.getRect(), ModContent.ItemType<jackalope_horns>());
				Item.NewItem(npc.getRect(), ModContent.ItemType<fur>());
			}
			if (Main.rand.Next(1) == 0)
            		{
				Item.NewItem(npc.getRect(), ModContent.ItemType<raw_meat>());
			}
		}


		public override bool? CanBeHitByItem(Player player, Item item) {
			return true;
		}

		public override bool? CanBeHitByProjectile(Projectile projectile) {
			return true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldDay.Chance * 0.5f;
		}

		public override void HitEffect(int hitDirection, double damage) {
			if (npc.life <= 0) {
				for (int i = 0; i < 6; i++) {
					int dust = Dust.NewDust(npc.position, npc.width, npc.height, 200, 2 * hitDirection, -2f);
					if (Main.rand.NextBool(2)) {
						Main.dust[dust].noGravity = true;
						Main.dust[dust].scale = 1.2f * npc.scale;
					}
					else {
						Main.dust[dust].scale = 0.7f * npc.scale;
					}
				}
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/BunnyHead"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/BunnyBody"), npc.scale);
			}
		}

		

		

		public override void OnCatchNPC(Player player, Item item) {
			item.stack = 1;

			try {
				var npcCenter = npc.Center.ToTileCoordinates();
				
			}
			catch {
				return;
			}
		}

		
	}

	internal class jackalopeItem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Jackalope");
		}

		public override void SetDefaults() {
			//item.useStyle = 1;
			//item.autoReuse = true;
			//item.useTurn = true;
			//item.useAnimation = 15;
			//item.useTime = 10;
			//item.maxStack = 999;
			//item.consumable = true;
			//item.width = 12;
			//item.height = 12;
			//item.makeNPC = 360;
			//item.noUseGraphic = true;
			//item.bait = 15;

			item.CloneDefaults(ItemID.Bunny);
			item.makeNPC = (short)ModContent.NPCType<jackalope>();
		}
	}
}