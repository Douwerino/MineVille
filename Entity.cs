using System.Numerics;
using Raylib_cs;

namespace MineVille
{
    public class Entity
    {
        private Raylib_cs.Texture2D texture;
        private Vector2 position;
        private Color color;
       
        public Entity(Raylib_cs.Texture2D _texture, Color _color, Vector2 _position)
        {
            texture = _texture;
            position = _position;
            color = _color;
        }

       public void drawPlayer(Texture2D _texture)
       {

       }
    

    }
}