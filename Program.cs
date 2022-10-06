﻿class HiLo
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Game game = new Game();
        int points = 0;
        while(!IsGameOver(game, player, points))
        {
            int DrawOne = game.FirstCard();
            
            string PlayerChoice = player.PlayerChoice();
            int DrawTwo = game.SecondDraw(DrawOne);
            points += game.IsHigher(DrawOne, DrawTwo, PlayerChoice, points);

        }
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
