using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame10
{
    public class Bullet:GameEntity
    {
        public override void LoadContent()
        {
            Sprite = Game1.Instance.Content.Load<Texture2D>("bullet");
        }

        public override void Update(GameTime gameTime)
        {
            float timeDelta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            float speed = 200.0f;

            Position += Look * timeDelta * speed;

            int width = Game1.Instance.Width;
            int height = Game1.Instance.Height;
            if ((Position.X > width) || (Position.X < 0)
                || (Position.Y > height) || (Position.Y < 0))
            {
                Alive = false;
            }
        }

        public override void Draw(GameTime gameTime)
        {
            Game1.Instance.spriteBatch.Draw(Sprite, Position, Color.White);
        }
    }
}
