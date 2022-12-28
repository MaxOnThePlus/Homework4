// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Stepen(int A, int B)
// {
//   int res = 1;
//   for(int i=1; i <= B; i++)
//    {
//     res = res * A;
//    }
//    return res;
// }

// Console.WriteLine("Введите первое число");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int B = Convert.ToInt32(Console.ReadLine());
// int result = Stepen(A,B);
// Console.WriteLine(result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumNumbers(int n)
// {
//     int sum = 0;
//     while (n>0)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     return sum;
// }

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = SumNumbers(n);
// Console.WriteLine(result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] CreateArray (int size, int minValue, int maxValue)
// {
//   int[] myArray = new int [size];
//   for(int i = 0;i < size; i++)
//   {
//    myArray[i] = new Random().Next(minValue, maxValue+1);
//   }
//   return myArray;
// }
// void ShowArray (int[] array)
// {
//   Console.WriteLine("Полученный массив:");
//   for(int i = 0; i < array.Length; i++)
//   {
//     Console.Write(array[i]+" ");
//   }
//   Console.WriteLine();
// }
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateArray(lenght,min,max));
