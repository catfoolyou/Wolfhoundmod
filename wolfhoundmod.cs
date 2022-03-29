using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using wolfhoundmod.Items;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace wolfhoundmod
{
	public class wolfhoundmod : Mod
	{

	Texture2D originalInflux;
	Texture2D originalIceblade;
	Texture2D originalFrost; 
	Texture2D originalSDMG;
	Texture2D originalEnchant;

	public static Mod TerrariaOverhaul;

	public override void Load() 
	{
            if (!Main.dedServ) {
                Main.itemTexture[ItemID.Spear] = GetTexture("Items/wooden_spear"); // Now we change it
		originalIceblade = Main.itemTexture[ItemID.IceBlade];
		Main.itemTexture[ItemID.IceBlade] = GetTexture("Items/1"); // Now we change it
		originalFrost = Main.itemTexture[ItemID.Frostbrand];
		Main.itemTexture[ItemID.Frostbrand] = GetTexture("Items/frostbrand"); // Now we change it
		Main.itemTexture[ItemID.AdamantiteSword] = GetTexture("Items/adamantite_sword"); // Now we change it
		originalInflux = Main.itemTexture[ItemID.InfluxWaver];
		Main.itemTexture[ItemID.InfluxWaver] = GetTexture("Items/influx_waver"); // Now we change it
		originalEnchant = Main.itemTexture[ItemID.EnchantedSword];
		Main.itemTexture[ItemID.EnchantedSword] = GetTexture("Items/enchanted_sword"); // Now we change it
		originalSDMG = Main.itemTexture[ItemID.SDMG];
		Main.itemTexture[ItemID.SDMG] = GetTexture("Items/sdmg"); // Now we change it
            }
        }

	public override void PostSetupContent()
        {
		TerrariaOverhaul = ModLoader.GetMod("TerrariaOverhaul");
	}

	public override void Unload()
        {
        	TerrariaOverhaul = null;
		Main.itemTexture[ItemID.InfluxWaver] = originalInflux;
		Main.itemTexture[ItemID.IceBlade] = originalIceblade;
		Main.itemTexture[ItemID.Frostbrand] = originalFrost; 
		Main.itemTexture[ItemID.SDMG] = originalSDMG;
		Main.itemTexture[ItemID.EnchantedSword] = originalEnchant;				
        }

		public override void AddRecipes() 
		{
			RecipeFinder finder = new RecipeFinder();
			finder.AddIngredient(ItemID.HallowedBar);
			foreach (Recipe recipedit in finder.SearchRecipes())
			{
				RecipeEditor editor = new RecipeEditor(recipedit);
				editor.DeleteRecipe();
			}

			RecipeFinder finder2 = new RecipeFinder();
			finder2.AddIngredient(ItemID.BloodButcherer);
			foreach (Recipe recipedit in finder2.SearchRecipes())
			{
				RecipeEditor editor = new RecipeEditor(recipedit);
				editor.DeleteRecipe();
			}

			ModRecipe recipe = new ModRecipe(this);
	  		recipe.AddIngredient(ItemID.CopperBar);
            		recipe.AddTile(17);
            		recipe.SetResult(ItemID.TinBar);
            		recipe.AddRecipe(); 

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.TinBar);
            		recipe.AddTile(17);
            		recipe.SetResult(ItemID.CopperBar);
            		recipe.AddRecipe(); 
			
			recipe = new ModRecipe(this);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.IronBar);
            		recipe.AddTile(TileID.WorkBenches);
            		recipe.SetResult((ItemID.ThrowingKnife), 10);
            		recipe.AddRecipe(); 

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.DesertFossil);
            		recipe.AddTile(TileID.WorkBenches);
            		recipe.SetResult((ItemID.FossilOre));
            		recipe.AddRecipe(); 
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient((ItemID.StoneBlock), 5);
			recipe.AddIngredient((ItemID.Wood), 10);
            		recipe.AddTile(TileID.WorkBenches);
            		recipe.SetResult((ItemID.Spear));
            		recipe.AddRecipe(); 
		
			recipe = new ModRecipe(this);
			recipe.AddIngredient((ItemID.HallowedBar), 12);
            		recipe.AddTile(134);
            		recipe.SetResult(ItemID.Excalibur);
            		recipe.AddRecipe(); 

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ItemID.HallowedBar), 12);
            		recipe.AddTile(134);
            		recipe.SetResult(ItemID.Gungnir);
            		recipe.AddRecipe(); 

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ItemID.HallowedBar), 12);
            		recipe.AddTile(134);
            		recipe.SetResult(ItemID.HallowedRepeater);
            		recipe.AddRecipe(); 

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ItemID.HallowedBar), 18);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(ItemID.SoulofSight);
			recipe.AddIngredient(ItemID.SoulofFright);
            		recipe.AddTile(134);
            		recipe.SetResult(ItemID.PickaxeAxe);
            		recipe.AddRecipe(); 

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.NightsEdge);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(ItemID.SoulofSight);
			recipe.AddIngredient(ItemID.SoulofFright);
            		recipe.AddTile(134);
            		recipe.SetResult(ItemID.TrueNightsEdge);
            		recipe.AddRecipe(); 

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Excalibur);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(ItemID.SoulofSight);
			recipe.AddIngredient(ItemID.SoulofFright);
            		recipe.AddTile(134);
            		recipe.SetResult(ItemID.TrueExcalibur);
            		recipe.AddRecipe(); 

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ItemID.HallowedBar), 18);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(ItemID.SoulofSight);
			recipe.AddIngredient(ItemID.SoulofFright);
            		recipe.AddTile(134);
            		recipe.SetResult(ItemID.Drax);
            		recipe.AddRecipe(); 

			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ModContent.ItemType<basic_ar>());
			recipe.AddIngredient(ItemID.SoulofMight, 20);
			recipe.AddTile(134);
			recipe.SetResult(ItemID.Uzi);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ModContent.ItemType<true_crimsaber>());
			recipe.AddIngredient(ItemID.TrueExcalibur);
			recipe.AddTile(134);
			recipe.SetResult(ItemID.TerraBlade);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
	  		recipe.AddIngredient(ItemID.TheUndertaker);
            		recipe.AddTile(TileID.Anvils);
            		recipe.SetResult(ItemID.Musket);
            		recipe.AddRecipe(); 

			recipe = new ModRecipe(this);
	  		recipe.AddIngredient(ItemID.Musket);
            		recipe.AddTile(TileID.Anvils);
            		recipe.SetResult(ItemID.TheUndertaker);
            		recipe.AddRecipe(); 

			recipe = new ModRecipe(this);
	  		recipe.AddIngredient(ItemID.EnchantedSword);
			recipe.AddIngredient((ItemID.SoulofLight), 10);
            		recipe.AddTile(134);
            		recipe.SetResult(ItemID.BeamSword);
            		recipe.AddRecipe(); 
	
			recipe = new ModRecipe(this);
			recipe.anyWood = true;
	  		recipe.AddIngredient(ItemID.Wood);
			recipe.AddIngredient(ModContent.ItemType<coal>());
            		//recipe.AddTile(TileID.Workbenches);
            		recipe.SetResult((ItemID.Torch), 3);
            		recipe.AddRecipe(); 
		}	    
	}
}
