class HiLo // creates the Hilo class
{
    static void Main(string[] args) // main function of the Game
    {
        Player player = new Player();
        Game game = new Game();// call the  Game function
        int points = 0;// initialize the points to zero at first
        do
        {
            int DrawOne = game.FirstCard();// checks the card drawn
            string PlayerChoice = player.PlayerChoice();
            int DrawTwo = game.SecondDraw(DrawOne);
            points += game.IsHigher(DrawOne, DrawTwo, PlayerChoice);

        }while(!IsGameOver(game, player, points));
    }

    static bool IsGameOver(Game game, Player player, int points)// checks Life points to continue or end game
    {
        if(game.IsGameOver(player.PlayerLifePoints(points)))
        {
            return true;
        }
        return false;
    }
}
