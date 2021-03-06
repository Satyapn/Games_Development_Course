﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace A19_Ex01_Ben_305401317_Dana_311358543
{
    public class Soul : Sprite
    {
        private const int k_MaxSoulsNumber = 3;
        private int m_CurrSoulsNumber = k_MaxSoulsNumber;
        private int m_SoulIndx;

        public Soul(Game i_Game, Color i_Tint, int i_SoulIndex) : base(i_Game)
        {
            this.m_AssetName = @"Sprites\Ship01_32x32";
            this.m_Tint = i_Tint;
            this.m_SoulIndx = i_SoulIndex;
        }

        public int SoulIndex
        {
            set
            {
                this.m_SoulIndx = value;
            }
        }

        public override void Draw(GameTime i_GameTime)
        {
            float scaleRate = 0.8f;
            SpriteBatch.Draw(this.Texture, this.Position, null, this.m_Tint, 0f, Vector2.Zero, scaleRate, SpriteEffects.None, 0f);
        }

        public override void InitPosition()
        {
            this.m_CurrSoulsNumber -= this.m_SoulIndx;
            float soulsGap = Texture.Width * 0.2f;
            this.Position = new Vector2(Game.GraphicsDevice.Viewport.Width - (this.m_CurrSoulsNumber * (Texture.Width + soulsGap)), 1); 
        }
    }
}
