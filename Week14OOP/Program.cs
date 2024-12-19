Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog ("Good girl");



Console.WriteLine($"My dogs name is {myDog.Name}. ");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}. ");

myDog.Rename("Bad boy");
Console.WriteLine($"Level of happiness: {myDog.levelOfHapiness}");

while (myDog.levelOfHapiness != 5)
{
    myDog.Bark();
}
myDog.Bark();
Console.WriteLine($"Level of happiness:{myDog.levelOfHapiness}");

myDog.WagTail();

class Dog
{
    private string _name; //field
    private int _levelOfHapiness = 0;

    //constructor
    public Dog(string name) //name -let the user name the dog
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter

    public string Name
    {
        get { return _name; }
    }
    public int levelOfHapiness
    {
        get { return _levelOfHapiness; }
    }



    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to {newName}");
    }
    
    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }

}

