using System;
using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;


namespace wolfhoundmod
{
    public class WHMWorld : ModWorld
    {
        //Setting up variables for invasion
        public static bool RaidUp = false;
        public static bool downedRaid = false;

        //Initialize all variables to their default values
        public override void Initialize()
        {
            Main.invasionSize = 0;
            RaidUp = false;
            downedRaid = false;
        }

        //Save downed data
        public override TagCompound Save()
        {
            var downed = new List<string>();
            if (downedRaid) downed.Add("Raid");

            return new TagCompound {
                {"downed", downed}
            };
        }

        //Load downed data
        public override void Load(TagCompound tag)
        {
            var downed = tag.GetList<string>("downed");
            downedRaid = downed.Contains("Raid");
        }

        //Sync downed data
        public override void NetSend(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = downedRaid;
            writer.Write(flags);
        }

        //Sync downed data
        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            downedRaid = flags[0];
        }

        //Allow to update invasion while game is running
        public override void PostUpdate()
        {
            if(RaidUp)
            {
                if(Main.invasionX == (double)Main.spawnTileX)
                {
                    //Checks progress and reports progress only if invasion at spawn
                    Raid.CheckRaidProgress();
                }
                //Updates the custom invasion while it heads to spawn point and ends it
                Raid.UpdateRaid();
            }
        }
    }
}