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

    public void drawPlayer(Texture texture)
    {
        DrawTexturePro(texture, new Raylib().Rectangle(0, 0,texture.width(), texture.height()),
            new Raylib().Rectangle(playerX, playerY, texture.width() * 2, texture.height() * 2),
            new Raylib.Vector2(0, 0), 0, Raylib.WHITE);
    }



    }
}