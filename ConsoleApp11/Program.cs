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

    }

    public void selling()
    {
        
    }

    public void watering()
    {
        
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
       
    }

    public void selling()
    {
       
    }

    public void watering()
    {
       
    }
}