using wolfhoundmod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class forest_staff : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Forest Staff");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.EmeraldStaff);
			item.damage = 28;
			item.mana = 5;
			item.shoot = 227;
			//item.shootSpeed = 25f;
		}
	}
}