﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace A19_Ex01_Ben_305401317_Dana_311358543
{
    class Bullet : Sprite
    {
        public enum BulletType { EnemyBullet, SpaceShipBullet };

        private BulletType m_Type;
        private readonly float r_BulletVelocity = 155;

        public override void Update(GameTime gameTime)
        {
           if(isBulletHitElement())//collision 
           {
                //destroy element
                m_visible = false;
           }
           else
           {
                Position = new Vector2(Position.X,Position.Y + Direction*r_BulletVelocity* (float)gameTime.ElapsedGameTime.TotalSeconds);
           }
        }

        public Bullet(Game game, BulletType bulletType ) :base(game)
        {
            m_AssetName = @"Sprites\Bullet";
            m_Type = bulletType;
        }

        private bool isBulletHitElement()//TODO: change name!
        {

            return false;
        }

        public void initialize()
        {

        }
        public override void initPosition()
        {

        }
    }
}
