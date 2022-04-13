using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using wolfhoundmod.Items;
using wolfhoundmod.Projectiles.Minions;

namespace wolfhoundmod
{
    public class ModGlobalNPC : GlobalNPC
    {

	public override void SetupShop(int type, Chest shop, ref int nextSlot) {
		if (type == NPCID.ArmsDealer) {
			if (Main.hardMode){
			shop.item[nextSlot].SetDefaults(ItemID.ClockworkAssaultRifle);
			nextSlot++;
			}
			}	
		}

	 //Change the spawn pool
        public override void EditSpawnPool(IDictionary< int, float > pool, NPCSpawnInfo spawnInfo)
        {
            //If the custom invasion is up and the invasion has reached the spawn pos
            if(WHMWorld. RaidUp&& (Main.invasionX == (double)Main.spawnTileX))
            {
                //Clear pool so that only the stuff you want spawns
                pool.Clear();
           
		//key = NPC ID | value = spawn weight
                //pool.add(key, value)
           
                //For every ID inside the invader array in our CustomInvasion file
                foreach(int i in Raid.invaders)
                {
                    pool.Add(i, 1f); //Add it to the pool with the same weight of 1
                }
            }
        }

        //Changing the spawn rate
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            //Change spawn stuff if invasion up and invasion at spawn
            if(WHMWorld. RaidUp&& (Main.invasionX == (double)Main.spawnTileX))
            {
                spawnRate = 100; //The higher the number, the less chance it will spawn (thanks jopojelly for how spawnRate works)
                maxSpawns = 10000; //Max spawns of NPCs depending on NPC value
            }
        }

	public override void PostAI(NPC npc)
        {
            //Changes NPCs so they do not despawn when invasion up and invasion at spawn
            if(WHMWorld.RaidUp && (Main.invasionX == (double)Main.spawnTileX))
            {
                npc.timeLeft = 1000;
            }
        }

		/*if (npc.type == NPCID.EyeofCthulhu || npc.type == NPCID.DukeFishron){
			music = mod.GetSoundSlot(Terraria.ModLoader.SoundType.Music, "Sounds/Music/Kirbyrocket_Boss1Redux");
		}
		if (npc.type == NPCID.KingSlime || npc.type == NPCID.SkeletronHead || npc.type == NPCID.SkeletronPrime || npc.type == NPCID.EaterofWorldsHead){
			music = mod.GetSoundSlot(Terraria.ModLoader.SoundType.Music, "Sounds/Music/Kirbyrocket_Boss1");
		}
		if (npc.type == NPCID.WallofFlesh || npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatizm){
			music = mod.GetSoundSlot(Terraria.ModLoader.SoundType.Music, "Sounds/Music/Kirbyrocket_Boss2");
		}
		if (npc.type == NPCID.BrainofCthulhu || npc.type == NPCID.TheDestroyer || npc.type == NPCID.Golem){
			music = mod.GetSoundSlot(Terraria.ModLoader.SoundType.Music, "Sounds/Music/Kirbyrocket_Boss3");
		}*/

        public override void NPCLoot(NPC npc)
        {

	//When an NPC (from the invasion list) dies, add progress by decreasing size
            if(WHMWorld.RaidUp)
            {
                //Gets IDs of invaders from CustomInvasion file
                foreach(int invaders in Raid.invaders)
                {
                    //If npc type equal to invader's ID decrement size to progress invasion
                    if(npc.type == invaders)
                    {
                        Main.invasionSize -= 1;
                    }
                }
            }

            if (Main.rand.Next(2) == 0)
            {
                if (npc.type == NPCID.Bunny)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("fur"));
                }
                if (npc.type == NPCID.Squirrel)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("fur"));
                }
		if (npc.type == NPCID.SquirrelRed)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("fur"));
                }
 		
            }
	   if (Main.rand.Next(1) == 0)
            {
                if (npc.type == NPCID.Bunny)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("raw_meat"));
                }
                if (npc.type == NPCID.Squirrel)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("raw_meat"));
                }
		if (npc.type == NPCID.SquirrelRed)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("raw_meat"));
                }
 		
            }
	 if (Main.rand.Next(10) == 0)
            {
                if (npc.type == NPCID.GreekSkeleton)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("terragrim"));
                }
                if (npc.type == NPCID.GraniteGolem)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ancient_blade"));
                }
		if (npc.type == NPCID.Harpy)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("fledgling_wings"));
                }
 		
            }
	  if (Main.rand.Next(50) == 0)
            {
		if (npc.type == NPCID.FaceMonster)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("acrimson_helmet"));
                }
		if (npc.type == NPCID.FaceMonster)
                {
		    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("acrimson_chestplate"));
                }
		if (npc.type == NPCID.FaceMonster)
                {
		    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("acrimson_boots"));
                }
		if (npc.type == NPCID.Crimera)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("acrimson_helmet"));
                }
		if (npc.type == NPCID.Crimera)
                {
		    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("acrimson_chestplate"));
                }
		if (npc.type == NPCID.Crimera)
                {
		    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("acrimson_boots"));
                }
		if (npc.type == NPCID.BloodCrawler)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("acrimson_helmet"));
                }
		if (npc.type == NPCID.BloodCrawler)
                {
		    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("acrimson_chestplate"));
                }
		if (npc.type == NPCID.BloodCrawler)
                {
		    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("acrimson_boots"));
                }
                
            }
        }
    }
}