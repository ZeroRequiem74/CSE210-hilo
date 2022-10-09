class HiLo // creates the Hilo class
{
    static void Main(string[] args) // main function of the Game
    {
        Player player = new Player();
        Game game = new Game();// call the  Game function
        int points = 0;// initialize the points to zero at first
        do// do these while in the main function.
        {
            int DrawOne = game.FirstCard();// from game class ca the first card function
            string PlayerChoice = player.PlayerChoice();//from player cass call the payer choice and returned vaue in Player choice
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
