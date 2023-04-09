Console.Write("Введите первое число: ");
string userInputА = Console.ReadLine();
int userNumberA = int.Parse(userInputА);
Console.WriteLine(userInputА);
Console.Write("Введите второе число: ");
string userInputB = Console.ReadLine();
int userNumberB = int.Parse(userInputB);
Console.WriteLine(userInputB);
Console.Write("Введите третье число: ");
string userInputC = Console.ReadLine();
int userNumberC = int.Parse(userInputC);
Console.WriteLine(userInputC);
int max = userNumberA;
    if(userNumberB>max)
    {
         max = userNumberB;
    }
    if(userNumberC>max)
    {
         max = userNumberC;
    }
Console.WriteLine($"{userNumberA},{userNumberB},{userNumberC} ->{max}");