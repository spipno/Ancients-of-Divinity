using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AncientsOfDivinity.Content.Items.Projectiles
{
    public class LycansinesSpadeBladeProjectile : ModProjectile
    {
        public override void SetDefaults()
        { 
         
        
            Projectile.width = 8;
            Projectile.height = 8;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.penetrate = 3;
            Projectile.timeLeft = 300;
            Projectile.light = 0.15f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.extraUpdates = 0;
            

        }
        public override void AI()
        {
            int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.Firework_Green, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust].velocity *= 0.8f;
            Main.dust[dust].scale = (float)Main.rand.Next(100, 135) * 0.013f;
            Main.dust[dust].noGravity = false;
        }
    }
}
