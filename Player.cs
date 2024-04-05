using System.Numerics;
using Raylib_cs;

namespace MineVille
{
    public class Player : Entity
    {
        int Coins;
        int Bronze;
        int Iron;
        int Gold;
        
        public Player(Raylib_cs.Texture2D texture, Color color, Vector2 position = new Vector2()) : base(texture, color, position)
        {
            
        }

        public void movement()
        {
            
        }

    }

}