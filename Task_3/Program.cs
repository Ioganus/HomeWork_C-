int N = new int();
Console.Write ("Enter number: ");
N = Convert.ToInt32(Console.ReadLine());
int count = 0;
Console.WriteLine("Even numbers");
while(count<N-1)
{
    count += 2;
    Console.WriteLine(count);
}
