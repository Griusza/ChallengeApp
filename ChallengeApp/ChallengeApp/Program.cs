var number = 51882220;
var numberInString = number.ToString();
char[] letters = numberInString.ToArray();
char[] arrayChar = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
int[] result = new int[10]; 

foreach (char c in letters)
{
    for (int j=0; j<10; j++)
    {
        if (c == arrayChar[j])
        {
            result[j]++;
            break;
        }
    }
}

for(var i=0; i<10; i++)
{
    Console.WriteLine(i + " => " + result[i]);
}
