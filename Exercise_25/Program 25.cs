// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

    

Console.WriteLine ("Введите число");
  
int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("Введите степень");
  
int stepen = Convert.ToInt32(Console.ReadLine());
int result = 1;
    for (int i=0; i < stepen; i++)
    {
      result = result*num;
    }
  Console.WriteLine(result);