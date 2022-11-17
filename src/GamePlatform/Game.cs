namespace GamePlatform
{
    public class Game
    {
        private Guid id;
        private readonly string name;

        private Money price;

        Game()
        {

        }

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
