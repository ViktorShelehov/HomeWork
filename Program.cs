Console.Write("Введите первое целое число: ");
string userInputА = Console.ReadLine();
int userNumberA = int.Parse(userInputА);
Console.WriteLine(userInputА);
Console.Write("Введите второе целое число: ");
string userInputB = Console.ReadLine();
int userNumberB = int.Parse(userInputB);
Console.WriteLine(userInputB);
    if (userNumberA > userNumberB)
    {
        Console.WriteLine($"a = {userNumberA}, b = {userNumberB} -> max = {userNumberA}");
    }
    else
    {
        Console.WriteLine($"a = {userNumberA}, b = {userNumberB} -> max = {userNumberB} ");
    }