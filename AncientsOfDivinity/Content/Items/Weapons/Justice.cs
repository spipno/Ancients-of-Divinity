using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace AncientsOfDivinity.Content.Items.Weapons
{
    public class Justice : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 80000;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 120;
            Item.useAnimation = 120;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 30;
            Item.value = Item.buyPrice(silver: 1);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }
    }
}
