namespace GamePlatform
{
    public class Game
    {
        private readonly string name;

        private Money price;

        public Game(string name)
        {
            this.name = name;
        }

        public void SetPrice(Money price)
        {
            this.price = price;
        }
    }
}
