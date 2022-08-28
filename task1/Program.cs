// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] matrix = new int[6,10];
void FillMatrix()
{
Random rand = new Random();
for (int i = 0; i < 6; i++)
{
   for (int j = 0; j < 10; j++)
   {
     matrix[i,j]= rand.Next(-10,11);
    
    Console.Write(" "+matrix[i,j] +" ");
   } 
   Console.WriteLine();
}
}
FillMatrix();
 Console.WriteLine("Введите номер строки:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int n = Convert.ToInt32(Console.ReadLine());

        if(m >matrix.GetLength(0) || n >matrix.GetLength(1))
         {

           Console.WriteLine("Такого индекса в массиве нет");
         }
         else
         {
            Console.WriteLine($"Значение элемента, расположенного на сторке {m} и  {n}  равно {matrix[m -1,n -1]}");
         } 

