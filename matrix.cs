using System;
class matrix
{
    public static void Main(string[] args)
    {
        int[,] array1 = new int[3, 3];
        int[,] array2 = new int[3, 3];

        Console.WriteLine("Enter the 3x3 matrix");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                array1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter the 3x3 matrix");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                array2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Addition matrix of two matrixces ::");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write((array1[i,j] + array2[i,j])+ "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Substraction matrix of two matrixces ::");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write((array1[i,j] - array2[i,j])+ "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Division matrix of two matrixces ::");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write((array1[i,j] / array2[i,j])+ "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Multiplication matrix of two matrixces ::");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write((array1[i,j] * array2[i,j])+ "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Modulous matrix of two matrixces ::");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write((array1[i,j] % array2[i,j])+ "\t");
            }
            Console.WriteLine();
        }
    }

}
