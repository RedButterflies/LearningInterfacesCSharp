//learning interfaces 
interface IPlant
{
    void planting();
    void watering();
    void selling();
}

class Rose : IPlant
{
    public string colour;
    public double weigth;

    public Rose(string colour, double weigth)
    {
        this.colour = colour;
        this.weigth = weigth;
    }

    public void planting()
    {
        Console.WriteLine("How many roses are you planting ?");
        int howMany = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many colours of roses are you planning on planting?");
        int colours = Convert.ToInt32(Console.ReadLine());
        String[] RoseColours = new string[colours];
        for (int i =0;i<colours; i++)
        {
            Console.WriteLine("Enter colour nr "+ Convert.ToInt16 (i+1));
            RoseColours[i] = Convert.ToString(Console.ReadLine());


        }

        Console.WriteLine("You are planning on planting "+colours+" roses in these colours:");
        foreach (string colour in RoseColours)
        {
            Console.WriteLine(colour);
        }
    }

    public void selling()
    {
        Console.WriteLine("Would you like to buy a rose? Enter 1 if YES or 0 if NO ");
        int answer = Convert.ToInt32(Console.ReadLine());
        if (answer == 0)
        {
            Console.WriteLine("You do not want to buy a rose, which is a great pity");

        }
        else if (answer == 1)
        {
            Console.WriteLine("What a great decision. You shall buy one from me ");

        }
        else
        {
            Console.WriteLine("You entered a wrong answer. Please try again");
        }
    }

    public void watering()
    {
        Console.WriteLine("How many roses did you water in the morning? ");
        int morning = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many roses did you water in the evening?");
        int evening = Convert.ToInt32(Console.ReadLine());
        int sum = morning+ evening;
        Console.WriteLine("You've watered "+sum+ " flowers today" );

    }
}
class Daisy : IPlant
{
    public int numberOfLeaves;
    public string colour;

    public Daisy(int numberOfLeaves, string colour)
    {
        this.numberOfLeaves = numberOfLeaves;
        this.colour = colour;
    }
    public void planting()
    {
        Console.WriteLine("Congratulations! You've planted a daisy!");
    }

    public void selling()
    {
        Console.WriteLine("Would you want to buy a daisy? Enter 1 if you do and 0 if you don't");
        int answer = Convert.ToInt32(Console.ReadLine());
        if (answer == 0)
        {
            Console.WriteLine("You do not want to buy a daisy, you might have to rethink your decision");

        }
        else if (answer == 1)
        {
            Console.WriteLine("What a great decision. You shall buy one from me ");

        }
        else
        {
            Console.WriteLine("You entered a wrong answer. Please try again");
        }
    }

    public void watering()
    {
        Console.WriteLine("How many buckets of water do you use to water your daisies in the morning? ");
        int morning= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What about the afternoon? ");
        int afternoon= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("And the evening? ");
        int evening = Convert.ToInt32(Console.ReadLine());
        int total = morning+ afternoon+ evening;
        Console.WriteLine("You use a total of "+total+" water buckets a day to water your daises. Remember not to overwater them !!!");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Daisy daisy = new Daisy(5, "blue");
        Rose rose = new Rose("red", 5.5d);
        daisy.planting();
        daisy.watering();
        daisy.selling();
        rose.selling();
        rose.planting();
        rose.watering();
    }
}