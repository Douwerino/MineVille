namespace MineVille
{
    public class Pickaxe
    {
        protected int tier;
        public int Damage { get; }
        public float Price { get; }

        public Pickaxe(int tier, int damage, float price)
        {
            this.tier = tier;
            Damage = damage;
            Price = price;
        }
    }
}