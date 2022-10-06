class HiLo
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Game game = new Game();
        int points = 0;
        while(IsGameOver(game))
        {
            int DrawOne = game.FirstCard();
            int DrawTwo = game.SecondDraw(DrawOne);
            string PlayerChoice = player.PlayerChoice();
            points += game.IsHigher(DrawOne, DrawTwo, PlayerChoice, points);
        }
    }

    static bool IsGameOver(Game game, Player player)
    {
        return false;
    }
}
