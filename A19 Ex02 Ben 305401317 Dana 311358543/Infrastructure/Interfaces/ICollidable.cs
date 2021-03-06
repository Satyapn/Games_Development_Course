﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Infrastructure
{
    // TODO 06: Define the base interface for collidable objects (2D/3D):
    public interface ICollidable
    {
        event EventHandler<EventArgs> PositionChanged;
        event EventHandler<EventArgs> SizeChanged;
        event EventHandler<EventArgs> VisibleChanged;
        event EventHandler<EventArgs> Disposed;

        bool Visible { get; }
        bool CheckCollision(ICollidable i_Source);
        void Collided(ICollidable i_Collidable);
    }
}

