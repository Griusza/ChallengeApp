string name = "Andrzej";
char sex = 'm';
int age = 37;

if (sex == 'f')
{
    if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else Console.WriteLine("Kobieta powyżej 30 lat");

}
else if (age < 18 && sex == 'm')
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else Console.WriteLine("Pełnoletni mężczyzna");