Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = n/10;

if(n < 100 || n >= 1000)
Console.WriteLine("число должно  быть трехзначным");
else
Console.WriteLine(x % 10);