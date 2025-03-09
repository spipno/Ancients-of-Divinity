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
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.penetrate = 5;
            Projectile.timeLeft = 300;
            Projectile.light = 0.15f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.extraUpdates = 0;
            

        }
        public override void AI()
        {
            Projectile.ai[0] += 1f;
            if (Projectile.ai[0] % 20 == 0 && Projectile.ai[0] < 250)
            {
                Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center, Projectile.velocity, ProjectileID.ThornChakram, 10, 7);
            }
        }
    }
}
