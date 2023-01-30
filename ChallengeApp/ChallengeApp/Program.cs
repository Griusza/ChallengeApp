using ChallengeApp;

Employee employee0 = new Employee("Andrzej", "Stefaniak", 37);
Employee employee1 = new Employee("Michał", "Wielki", 24);
Employee employee2 = new Employee("Kasia", "Kowalska", 30);
List<Employee> list = new List<Employee>();
list.Add(employee0);
list.Add(employee1);
list.Add(employee2);

employee0.AddScore(4);
employee0.AddScore(2);
employee0.AddScore(7);
employee0.AddScore(9);
employee0.AddScore(1);

employee1.AddScore(7);
employee1.AddScore(2);
employee1.AddScore(1);
employee1.AddScore(9);
employee1.AddScore(9);

employee2.AddScore(3);
employee2.AddScore(5);
employee2.AddScore(1);
employee2.AddScore(9);
employee2.AddScore(1);

if (employee0.Score > employee1.Score)
{
    if (employee0.Score > employee2.Score)
    {
        PrintTheBest(0);
    }
    else
    {
        PrintTheBest(2); 
    }
}
else
{
    if (employee0.Score > employee2.Score)
    {
        PrintTheBest(1);
    }
    else
    { 
        PrintTheBest(2); 
    }
}

void PrintTheBest(int i)
{
    Console.WriteLine("Najwyższą liczbę ocen posiada uzytkownik:");
    Console.WriteLine(list[i].name + " " + list[i].surname + " " + "lat " +list[i].age);
    Console.WriteLine("Jego wynik to: " + list[i].Score);
}