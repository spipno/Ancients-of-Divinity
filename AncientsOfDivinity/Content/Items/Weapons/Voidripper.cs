using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace AncientsOfDivinity.Content.Items.Weapons
public class Voidripper : ModItem
{
		.
		public override void SetDefaults()
    {
        Item.damage = 6000;
        Item.DamageType = DamageClass.Melee;
        Item.width = 40;
        Item.height = 40;
        Item.useTime = 10;
        Item.useAnimation = 10;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.knockBack = 6;
        Item.value = Item.buyPrice(silver: 1);
        Item.rare = ItemRarityID.Yellow;
        Item.UseSound = SoundID.Item1;
        Item.autoReuse = true;
    }
}
}
