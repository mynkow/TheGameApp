namespace GamePlatform
{
    public class GameAppService
    {
        public Guid CreateGame(string name)
        {
            var game = new Game(name);

            return Guid.NewGuid();
            // save db
        }

        public void SetPrice(Guid gameId, Money gamePrice)
        {
            // load db byId(gameId)
            Game game = new Game("alabala");
            game.SetPrice(gamePrice);
            // save db
        }
    }
}
