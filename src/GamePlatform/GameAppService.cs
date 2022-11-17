namespace GamePlatform
{
    public class GameAppService
    {
        public void CreateGame(string name)
        {
            var game = new Game(name);
            // save db
        }

        public void SetPrice(Guid gameId, Money gamePrice)
        {
            // load db byId(gameId)
            Game game = default;
            game.SetPrice(gamePrice);
            // save db
        }
    }
}
