namespace Type_Basics_3;

public class Panda
{
    public string Name;
    public static int Population;

    public Panda(string name)
    {
        Name = name;
        Population += 1;
    }
}