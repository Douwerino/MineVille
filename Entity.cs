using Raylib_cs;

namespace MineVille
{
    public class Entity
    {
       Raylib_cs.Texture2D texture;
       
        private Vector2 position;
            private Color color;

       public void DrawEntity(Texture2D _texture)
       {
        Raylib.DrawTexture(texture, (int) position.x(), (int) position.y(), color);


       }



    }
}