class Game // Our Game class
{
    public int FirstCard() // Function for the First card Drawn
    {
        Random rnd = new Random();
        int DrawOne = rnd.Next(1, 14);// Card will be selected at random from 1 - 13
        Console.WriteLine($"The card is: {DrawOne}");
        return DrawOne;//Value  card drawn in first choice is returned 
    }

    public int SecondDraw(int DrawOne)// Second card is drawn here
    {
        int DrawTwo = 0;
        do
        {
            Random rnd = new Random();
            DrawTwo = rnd.Next(1,14);
        }while(DrawTwo == DrawOne);
        Console.WriteLine($"Next card was: {DrawTwo}");
        return DrawTwo;
    }
    public int IsHigher(int DrawOne, int DrawTwo, string guess)
    {
        int points = 0;
        if(guess == "l")
        {
            if(DrawOne > DrawTwo)// compare the first and second card
            {
                points += 100;// if first card is greater the  second card add  100 point to player 
            }
            else
            {
                points += -75;// if the above is fas subtract 75 points 
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
        if (LifePoints <= 0)
        {
            End = true;
        }
        else
        {
            Console.Write("Play Again? [y/n] ");// write this on the terminal
            string? choice = Console.ReadLine();
            if(choice == "y")// if player chooses y , execute the bock below if not enter the ese block
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