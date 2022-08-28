// Console.WriteLine("Hello, World!");
Console.Clear();

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] RandomArray = new double [10];
//   for(int i = 0; i< 10; i++)
//   {
//   RandomArray[i]= new Random().Next(15,50);
//   Console.Write(RandomArray[i] + "|");
//   }
    
// double max = RandomArray[0];
// double min = RandomArray[0];

// for (int i = 1; i < RandomArray.Length; i++)
//   {
//     if (max < RandomArray[i])
//     {
//       max = RandomArray[i];
//     }
//         if (min > RandomArray[i])
//     {
//       min = RandomArray[i];
//     }
//   }
// double difference = max - min;
 
// Console.WriteLine($"The difference from {max} and {min} = {difference}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Console.Write($"input length of array: ");
// int Length = Convert.ToInt32(Console.ReadLine()); 
// int[] RandomArray = new int [Length];
// int sum=0;
// for (int i = 0; i < RandomArray.Length; i++)
// {
// RandomArray[i] = new Random().Next(-3,10);
// Console.Write(RandomArray[i] + "|");
// }
// for (int i = 0; i < RandomArray.Length; i++)
// if(i%2 != 1)
// {
// sum = sum + RandomArray[i];
// }

// Console.WriteLine($" -> Сумма элементов стоящих на нечетных позициях = {sum}");

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.Write($"input length of array: ");
// int Length = Convert.ToInt32(Console.ReadLine()); 
// int[] ThreedigitArray = new int [Length];
// int quantity=0;
// for (int i = 0; i < ThreedigitArray.Length; i++)
// {
// ThreedigitArray[i] = new Random().Next(100,999);
// Console.Write(ThreedigitArray[i] + "|");
// }
// for (int i = 0; i < ThreedigitArray.Length; i++)
// if(ThreedigitArray[i] % 2 == 0)
// {
//     quantity = quantity + 1;
// }
// Console.WriteLine($" -> Количество четных чисел в массиве = {quantity}");