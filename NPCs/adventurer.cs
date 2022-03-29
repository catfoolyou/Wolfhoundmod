using System; 
using Microsoft.Xna.Framework; 
using wolfhoundmod.Items; 
using wolfhoundmod.Items.Armor;
using Terraria; 
using Terraria.ID; 
using Terraria.Localization; 
using Terraria.ModLoader; 
using static Terraria.ModLoader.ModContent; 

namespace wolfhoundmod.NPCs
{
	[AutoloadHead] // Loads the NPC's head on the player map.
    public class adventurer : ModNPC // Required generic identifier.
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Adventurer");
	    Main.npcFrameCount[npc.type] = 26; // Checks for the amount of frames the following NPC has and applies the same amount of frame to your NPC. By default, this is set to 1.
            NPCID.Sets.ExtraFramesCount[npc.type] = 9; // The amount of frames your NPC has that are not focused walking or attacking, this includes frames for sitting and chatting.
            NPCID.Sets.AttackFrameCount[npc.type] = 5; // The amount of frames your NPC uses while attacking.
            // The remaining frames that are left over are used for the NPC's walking animation.
            NPCID.Sets.DangerDetectRange[npc.type] = 700; // How far a Town NPC can detect an enemy.
            NPCID.Sets.AttackType[npc.type] = 1; // The attack style an NPC copies. Set to 0 if the NPC has a custom attack.
            NPCID.Sets.AttackTime[npc.type] = 150; // How fast your NPC can attack.
            NPCID.Sets.AttackAverageChance[npc.type] = 10; // The chance in which an NPC will attack rather than flee.
            NPCID.Sets.HatOffsetY[npc.type] = 4; // The Y offset of the NPC's party hat, useful for taller NPCs.
        }

        public override void SetDefaults()
        {
            npc.friendly = true; // Check if the NPC should be unable to harm the player or any other friendly NPCs.
            npc.townNPC = true; // Check if the NPC is a town NPC and requires a suitable housing.
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 8;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            aiType = 22; // What type of AI an NPC copies.
            animationType = 22;
        }

	/*public override bool CanTownNPCSpawn(int numTownNPCs, int money) {
		!NPC.AnyNPCs(mod.NPCType("adventurer"))
        }*/

	 public override bool CanTownNPCSpawn(int numTownNPCs, int money) {
            for (int k = 0; k < 255; k++) {
                Player player = Main.player[k];
                if (!player.active) {
                    continue;
                }
            }
            return false;
        }

	public override void TownNPCAttackStrength(ref int damage, ref float knockback) {
            damage = 15; // The amount of damage the Town NPC inflicts.
            knockback = 4f; // The amount of knockback the Town NPC inflicts.
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown) {
            cooldown = 20; // The amount of ticks the Town NPC takes to cool down. Every 60 in-game ticks is a second.
            randExtraCooldown = 20; // How long it takes until the NPC attacks again, but with a chance.
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay) {
            projType = 660; // The Projectile this NPC shoots. Search up Terraria Projectile IDs, I cannot link the websites in this code
            attackDelay = 1; // Delays the attacks, obviously.
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset) {
            multiplier = 12f; // The Speed of the Projectile
            randomOffset = 2f; // Random Offset
        }

	 public override string GetChat() {
            // these lines of code are an example of how NPCs can refer to others, most NPCs often use this to hint a relationship between them and another.
            int dryad = NPC.FindFirstNPC(NPCID.Dryad);
            if (dryad >= 0 && Main.rand.NextBool(8)) {
                return "I feel quite safe around " + Main.npc[dryad].GivenName + ". Her aura protects me from the outer dangers.";
            }
            // Generic TownNPC dialogue
            switch (Main.rand.Next(8)) {
                case 0:
                    return "Guardians? I don't know. Go ask the Guide about that kind of stuff.";
                case 1:
                    return "Desert? You know about that? I would consider that 'The forbidden wasteland'.";
                case 2:
                    return "Watch out for the guardians... What? Wanna buy something?";
                case 3:
                    return "Is that a GUN!? I could really use one of those...";
                case 4:
                    return "HEY! Stop fooling around with that sword! You're gonna kill yourself.";
                default:
                    return "Want to try on my cloak? No?";
            }
        }

	public override string TownNPCName() {
            switch (WorldGen.genRand.Next(16)) {
                case 0:
                    return "Jesse";
                case 1:
                    return "Darkstalker";
                case 2:
                    return "Max";
                case 3:
                    return "Cath";
		case 4:
                    return "Steve";
                case 5:
                    return "Robert";
                default:
                    return "Wolfhound";
            }
        }

	public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Language.GetTextValue("LegacyInterface.28");
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
				return;
			}
		}
	
	public override void SetupShop(Chest shop, ref int nextSlot) {
		shop.item[nextSlot].SetDefaults(ItemID.WoodenArrow);
		nextSlot++;
		shop.item[nextSlot].SetDefaults(ItemID.Torch);
		nextSlot++;
		shop.item[nextSlot].SetDefaults(ItemID.IronPickaxe);
		nextSlot++;
		shop.item[nextSlot].SetDefaults(ItemID.IronAxe);
		nextSlot++;
		shop.item[nextSlot].SetDefaults(ItemID.ManaPotion);
		nextSlot++;
		shop.item[nextSlot].SetDefaults(ItemID.HealingPotion);
		nextSlot++;
		shop.item[nextSlot].SetDefaults(ItemID.MagicMirror);
		nextSlot++;
		if (NPC.downedBoss1){
			shop.item[nextSlot].SetDefaults(ItemID.WoodenCrate);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("sand_slasher"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("scarab_bow"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("dune_splicer"));
			nextSlot++;
			}
		if (NPC.downedBoss2){
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<coal>());
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<opal_staff>());
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<onyx_staff>());
			nextSlot++;
			}
		if (NPC.downedBoss3){
			shop.item[nextSlot].SetDefaults(ItemID.IronCrate);
			nextSlot++;
			}
		if (Main.hardMode){
			shop.item[nextSlot].SetDefaults(ItemID.AncientBattleArmorMaterial);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.FrostCore);
			nextSlot++;
			}
		
        }
    }
}