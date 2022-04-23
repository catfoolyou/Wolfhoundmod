using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using wolfhoundmod.Items;

namespace wolfhoundmod.NPCs.Bosses
{
	[AutoloadBossHead]
	// Darkness is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class darkness : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("The Dark One");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults() {
			npc.CloneDefaults(NPCID.Retinazer);
			aiType = NPCID.Retinazer;
			animationType = NPCID.Retinazer;
			npc.damage = 60;
			npc.defense = 26;
			npc.lifeMax = 18000;
			music = mod.GetSoundSlot(Terraria.ModLoader.SoundType.Music, "Sounds/Music/Darkness");
		}
		
		public override void BossLoot(ref string name, ref int potionType)
		{
    			potionType = ItemID.GreaterHealingPotion;
    			base.BossLoot(ref name, ref potionType);
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
            		{
			int choice = Main.rand.Next(1,5);
				if(choice == 1)
					Item.NewItem(npc.getRect(), ItemID.DD2SquireDemonSword);
				else if(choice == 2)
					Item.NewItem(npc.getRect(), ItemID.DD2PhoenixBow);
				else if(choice == 3)
					Item.NewItem(npc.getRect(), ItemID.BookStaff);
				else if(choice == 4)
					Item.NewItem(npc.getRect(), ItemID.OnyxBlaster);
			}
		if (Main.rand.Next(1) == 0)
            		{
				Item.NewItem(npc.getRect(), ModContent.ItemType<wulfrum_bar>(), Main.rand.Next(20, 30));
				Item.NewItem(npc.getRect(), ItemID.SoulofNight, Main.rand.Next(15, 18));
			}
		if (Main.rand.Next(5) == 0)
            		{
				Item.NewItem(npc.getRect(), ItemID.Uzi);
			}
		}
	}
}