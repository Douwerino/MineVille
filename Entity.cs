namespace MineVille
{
    public class Entity
    {
       Texture2D texture;
       
        private Vector2 position;
            private Color color;

       public void DrawEntity(Texture2D _texture)
       {
        DrawTexture(texture, (int) position.x(), (int) position.y(), color);


       }



    }
}