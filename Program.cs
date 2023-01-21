Console.WriteLine("Введите день недели: "); 
   int n = Convert.ToInt32(Console.ReadLine());
   if(n<1 || n>7)
      Console.WriteLine("Вы ошиблись!\nВведите день недели: "); 
   else if(n==6 || n==7)
   Console.WriteLine("выходной");
   else
   Console.WriteLine("будний день");