
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b)
  {
    if(a > c)
     {
        Console.WriteLine("Первое число максимальное.");
     }
  }

if(b > a)
  {
    if(b > c)
      {
        Console.WriteLine("Второе число максимальное.");
      }
  }  

if(c > a)
  {
     if(c > b)
      {
        Console.WriteLine("Третье число максимальное.");
      }
  }

if(a == b & c == b)
   {
    Console.WriteLine("Все три числа равны.");
   }

if(a == b & a > c)

   {
    Console.WriteLine("Первое и второе числа максимальные.");
   }

if(a == c & a > b)
   {
    Console.WriteLine("Первое и третье числа максимальные.");
   }

if(b == c & b > a)
    {
       Console.WriteLine("Второе и третье числа максимальные.");
    }
    
