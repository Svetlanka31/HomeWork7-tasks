// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
 
  
int[,] matrix = new int[m,n];
FillMatrix(matrix); 


 for (int j = 0; j <n; j++)
    { 
       double sum =0;
        for (int i = 0; i <m; i++)
        {
            sum = sum + matrix[i,j];
            
        }
         sum =Math.Round(sum/m,1);
   
       Console.WriteLine($"среднее арифметическое столбца{j+1} = {sum}");
    } 
   
void FillMatrix(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
   for (int j = 0; j < matrix.GetLength(1); j++)
   {
     matrix[i,j]= new Random().Next(-10,11);
    
    Console.Write(matrix[i,j] +" "+" ");
   } 
   Console.WriteLine();
} 
}
 Console.WriteLine();
