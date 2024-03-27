using Raylib_cs;

namespace MineVille
{
    public class Entity
    {
        private Raylib_cs.Texture2D texture;
        private Raylib_cs.Vector2 position;
        private Color color;
       
        // public Entity(Raylib_cs.Texture2D _texture, Raylib_cs.Vector2 _position, Color _color)
        // {
        //     texture = _texture;
        //     position = _position;
        //     color = _color;
        // }

       public void DrawEntity(Texture2D _texture)
       {
        Raylib.DrawTexture(texture, (int) position.x(), (int) position.y(), color);


       }


    }
}