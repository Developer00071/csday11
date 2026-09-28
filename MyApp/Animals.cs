namespace MyApp;

abstract class Animal
{
    public string Name;
    public void SetName(string name)
    {
        Name = name;
    }

    public void GetName()
    {
        Console.WriteLine(Name);
    }

    public abstract void Eat();
}
