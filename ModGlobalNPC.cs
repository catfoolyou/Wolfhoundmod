using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using wolfhoundmod.Items;
using wolfhoundmod.Projectiles.Minions;

namespace wolfhoundmod
{
    public class ModGlobalNPC : GlobalNPC
    {

        public override void NPCLoot(NPC npc)
        {
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
	 if (Main.rand.Next(15) == 0)
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