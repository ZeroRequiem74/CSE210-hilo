class HiLo // creates the Game class
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Game game = new Game();
        int points = 0;
        do
        {
            int DrawOne = game.FirstCard();
            string PlayerChoice = player.PlayerChoice();
            int DrawTwo = game.SecondDraw(DrawOne);
            points += game.IsHigher(DrawOne, DrawTwo, PlayerChoice);

        }while(!IsGameOver(game, player, points));
    }

    static bool IsGameOver(Game game, Player player, int points)
    {
        if(game.IsGameOver(player.PlayerLifePoints(points)))
        {
            return true;
        }
        return false;
    }
}
