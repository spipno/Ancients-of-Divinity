using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientsOfDivinity.Content.Items.Projectiles
{
    public class LycansinesSpadeBladeProjectile : ModProjectile
    {
        public override void SetDefaults()
        { 
         
        
            Projectile.width = 32;
            Projectile.height = 32;
            Projectile.aiStyle = 70;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.penetrate = 5;
            Projectile.timeLeft = 300;
            Projectile.light = 0.15f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = false;
            Projectile.extraUpdates = 0;
            

        }
        
    }
}
