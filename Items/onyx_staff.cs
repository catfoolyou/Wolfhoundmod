using wolfhoundmod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace wolfhoundmod.Items
{
	public class onyx_staff : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Onyx Staff");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.EmeraldStaff);
			item.damage = 17;
			item.mana = 5;
			item.shoot = 121;
			item.shootSpeed = 25f;
		}
	}
}