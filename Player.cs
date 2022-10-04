class Player
{
    public int PlayerLifePoints(int points)
    {
        int LifePoints = 300;
        LifePoints = LifePoints + points;

        return LifePoints;
    }
    public string PlayerChoice()
    {
        Console.Write("Higher or lower? [h/l] ");
        string choice = Console.ReadLine() ?? "";
        return choice;
    }
}