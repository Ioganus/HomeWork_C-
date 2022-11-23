int userNumber = new int();
Console.Write("Enter number: ");
userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber % 2 == 0)
    Console.Write("да");
else
    Console.Write ("Нет");