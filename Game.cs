class Game
{
    public int FirstCard()
    {
        Random rnd = new Random();
        int DrawOne = rnd.Next(1, 14);
        return DrawOne;
    }

    public int SecondDraw(int DrawOne)
    {
        int DrawTwo = 0;
        do
        {
            Random rnd = new Random();
            DrawTwo = rnd.Next(1,14);
        }while(DrawTwo == DrawOne);
        return DrawTwo;
    }
    public int IsHigher(int DrawOne, int DrawTwo, string guess)
    {
        int points = 0;
        if(guess == "l")
        {
            if(DrawOne > DrawTwo)
            {
                points += 100;
            }
            else
            {
                points += -75;
            }
        }
        else if(guess == "h")
        {
        
            if(DrawOne > DrawTwo)
            {
                points += -75;
            }
            else
            {
                points += 100;
            }
        }
        return points;
    }

    public bool IsGameOver(int LifePoints)
    {
        bool End = false;
        if (LifePoints == 0)
        {
            End = true;
        }
        else
        {
            Console.Write("Play Again? [y/n] ");
            string? choice = Console.ReadLine();
            if(choice == "y")
            {
                End = false;
            }
            else
            {
                End = true;
            }
        }
        return End;
    }
}