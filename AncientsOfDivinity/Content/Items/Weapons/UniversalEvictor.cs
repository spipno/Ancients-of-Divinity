using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace AncientsOfDivinity.Content.Items.Weapons
{
    public class UniversalEvictor : ModItem 
    {
        public override void SetDefaults()
        {
            Item.damage = 300000;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 80;
            Item.useAnimation = 80;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 14;
            Item.value = Item.buyPrice(silver: 1);
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }
    }
}
