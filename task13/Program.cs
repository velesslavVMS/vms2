Console.Write("Введите число: ");
 int n = Convert.ToInt32(Console.ReadLine());
 int k=n;
 int m=0;
 int i = 0;
 int x = n;
 int y = 0;
 int z =0;
  if(n<100)
 Console.WriteLine("третьей цифры нет");
 else if(n<1000)
 {
         y=(n % 10);
     }
else
{
 while(k/10>=1)
{ {
    k=k/10;
    m=(k % 10);
    i=i+1;
    /*Console.Write($"{m}  ");
    Console.Write("i= ");
       Console.WriteLine(i);*/
 }
 while(z < i-2)   
       {
        x=x/10;
    y=(x % 10);
    z=z+1;
           }  
       } }
Console.Write("цифра= ");
Console.WriteLine(y);

 