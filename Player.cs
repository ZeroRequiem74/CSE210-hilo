class Player// creates  the Player class
{
    public int PlayerLifePoints(int points)// monitors the player's points
    {
        int LifePoints = 300;// player has 300 points at the beginning of the game
        LifePoints = LifePoints + points; // adds  points to life points 
        Console.WriteLine($"Your score is: {LifePoints}");// this will be printed on the terminal for the payer
        return LifePoints;// returns the ife points value
    }
    public string PlayerChoice()
    {
        Console.Write("Higher or lower? [h/l] ");
        string choice = Console.ReadLine() ?? "";//store the payer's input into the choice variable
        return choice;
    }
}