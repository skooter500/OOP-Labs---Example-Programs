using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame10
{
    public class Tank:GameEntity
    {
        float rot = 0.0f;
        float scale = 1.0f;

        public override void LoadContent()
        {
            Position = new Vector2(100, 100);
            Look = new Vector2(0, -1);
            Sprite = Game1.Instance.Content.Load<Texture2D>("smalltank");
        }

        float fireRate = 2.0f;
        float elapsedTime = 10.0f;
        
        public override void Update(GameTime gameTime)
        {
            float hasToPass = 1.0f / fireRate;

            KeyboardState kState = Keyboard.GetState();

            float timeDelta = (float) gameTime.ElapsedGameTime.TotalSeconds;
            float speed = 100.0f;

            
            if (kState.IsKeyDown(Keys.Space) && (elapsedTime > hasToPass))
            {
                Bullet b = new Bullet();
                float turretDist = 26.0f;
                b.Position = Position + Look * turretDist;
                b.Look = Look;
                b.LoadContent();
                Game1.Instance.Entities.Add(b);
                elapsedTime = 0.0f;
            }
            elapsedTime += timeDelta;

            if (kState.IsKeyDown(Keys.Up))
            {
                Position += speed * timeDelta * Look;
            }

            if (kState.IsKeyDown(Keys.Down))
            {
                Position -= speed * timeDelta * Look;
            }

            if (kState.IsKeyDown(Keys.Left))
            {
                rot -= timeDelta;
            }

            if (kState.IsKeyDown(Keys.Right))
            {
                rot += timeDelta;
            }

            
            Look.X = (float)Math.Sin(rot);
            Look.Y = -(float)Math.Cos(rot);
        }

        public override void Draw(GameTime gameTime)        
        {
            Vector2 cent = new Vector2();
            cent.X = Sprite.Width / 2;
            cent.Y = Sprite.Height / 2;

            Game1.Instance.spriteBatch.Draw(Sprite, Position, null, Color.White, rot, cent, scale, SpriteEffects.None, 1); 
        }


    }
}
