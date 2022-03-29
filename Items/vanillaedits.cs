using Terraria.ID;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using wolfhoundmod.Projectiles;

namespace wolfhoundmod.Items 
{
	public class vanillaedits : GlobalItem 
	{

        	public override void SetDefaults(Item item) {
			if (item.type == ItemID.BeamSword) { // Here we make sure to only change Platinum Shortsword by checking item.type in an if statement
				item.autoReuse = true;
				item.useTime = 20;
			}
			
			if (item.type == ItemID.CopperShortsword) { // Here we make sure to only change Copper Shortsword by checking item.type in an if statement
				item.useStyle = ItemUseStyleID.HoldingOut;
				item.useAnimation = 18;
				item.shootSpeed = 3.7f;

				item.melee = true;
				item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
				item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
				item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

				item.UseSound = SoundID.Item1;
				item.shoot = ModContent.ProjectileType<Copper_Shortsword>();
			}

			if (item.type == ItemID.ElectrosphereLauncher) { // Here we make sure to only change Platinum Shortsword by checking item.type in an if statement
				item.autoReuse = true;
			}

			/*if (item.type == ItemID.Arkhalis) { // Overhaul fix check
				item.shoot = 595;
			}*/

			if (item.type == ItemID.GoldShortsword) { // Here we make sure to only change Gold Shortsword by checking item.type in an if statement
				item.useStyle = ItemUseStyleID.HoldingOut;
				item.useAnimation = 18;
				item.shootSpeed = 3.7f;

				item.melee = true;
				item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
				item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
				item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

				item.UseSound = SoundID.Item1;
				item.shoot = ModContent.ProjectileType<Gold_Shortsword>();
			}

			if (item.type == ItemID.IronShortsword) { // Here we make sure to only change Iron Shortsword by checking item.type in an if statement
				item.useStyle = ItemUseStyleID.HoldingOut;
				item.useAnimation = 18;
				item.shootSpeed = 3.7f;
			
				item.melee = true;
				item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
				item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
				item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

				item.UseSound = SoundID.Item1;
				item.shoot = ModContent.ProjectileType<Iron_Shortsword>();
			}
	
			if (item.type == ItemID.LeadShortsword) { // Here we make sure to only change Lead Shortsword by checking item.type in an if statement
				item.useStyle = ItemUseStyleID.HoldingOut;
				item.useAnimation = 18;
				item.shootSpeed = 3.7f;

				item.melee = true;
				item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
				item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
				item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

				item.UseSound = SoundID.Item1;
				item.shoot = ModContent.ProjectileType<Lead_Shortsword>();
			}

			if (item.type == ItemID.NightsEdge) { 
				item.autoReuse = true;
			}

			if (item.type == ItemID.OnyxBlaster) { // Here we make sure to only change Platinum Shortsword by checking item.type in an if statement
				item.autoReuse = true;
			}

			if (item.type == ItemID.PlatinumShortsword) { // Here we make sure to only change Platinum Shortsword by checking item.type in an if statement
				item.useStyle = ItemUseStyleID.HoldingOut;
				item.useAnimation = 18;
				item.shootSpeed = 3.7f;

				item.melee = true;
				item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
				item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
				item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

				item.UseSound = SoundID.Item1;
				item.shoot = ModContent.ProjectileType<Platinum_Shortsword>();
			}

			if (item.type == ItemID.SilverShortsword) { // Here we make sure to only change Silver Shortsword by checking item.type in an if statement
				item.useStyle = ItemUseStyleID.HoldingOut;
				item.useAnimation = 18;
				item.shootSpeed = 3.7f;

				item.melee = true;
				item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
				item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
				item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

				item.UseSound = SoundID.Item1;
				item.shoot = ModContent.ProjectileType<Silver_Shortsword>();
			}

			if (item.type == ItemID.Spear) { // Here we make sure to only change Silver Shortsword by checking item.type in an if statement
				item.shoot = ModContent.ProjectileType<wooden_spear1>();
			}

			if (item.type == ItemID.TinShortsword) { // Here we make sure to only change Tin Shortsword by checking item.type in an if statement
				item.useStyle = ItemUseStyleID.HoldingOut;
				item.useAnimation = 18;
				item.shootSpeed = 3.7f;

				item.melee = true;
				item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
				item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
				item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

				item.UseSound = SoundID.Item1;
				item.shoot = ModContent.ProjectileType<Tin_Shortsword>();
			}

			if (item.type == ItemID.TrueNightsEdge) { 
				item.autoReuse = true;
			}

			if (item.type == ItemID.TrueExcalibur) { 
				item.autoReuse = true;
			}

			if (item.type == ItemID.TungstenShortsword) { // Here we make sure to only change Tungsten Shortsword by checking item.type in an if statement
				item.useStyle = ItemUseStyleID.HoldingOut;
				item.useAnimation = 18;
				item.shootSpeed = 3.7f;
	
				item.melee = true;
				item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
				item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
				item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

				item.UseSound = SoundID.Item1;
				item.shoot = ModContent.ProjectileType<Tungsten_Shortsword>();
			}

			if (item.type == ItemID.VenusMagnum) { // Here we make sure to only change Platinum Shortsword by checking item.type in an if statement
				item.autoReuse = true;
				item.useTime = 20;
			}
			
			if (item.type == ItemID.BoneSword) { 
				item.autoReuse = true;
			}
		}
	
	}
}