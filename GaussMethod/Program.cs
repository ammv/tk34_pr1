using System;
//using System.Collections.Generic;

namespace gauss
{
    class GaussMethod
    {
        static double[] AddLines(double[] a, double[] b)
        {
            double[] c = new double[a.Length];
            for(int i = 1; i < a.Length; i++)
            c[i] = a[i] + b[i];
            return c;
        }
        static double[] DivLine(double[] a, double n)
        {
            for(int i = 1; i < a.Length; i++)
            a[i] /= n;
            return a;
        }
        static double[] MulLine(double[] a, double n)
        {
            for(int i = 1; i < a.Length; i++)
            a[i] *= n;
            return a;
        }
        static double[] GetLineMatrix(double[,] matrix, int line)
        {
            double[] matrixLine = new double[matrix.GetLength(1)];
            for(int j = 0; j < matrix.GetLength(1); j++)
            matrixLine[j] = matrix[line, j];
            return matrixLine;
        }
        static double[,] UpdateLineMatrix(double[,] matrix, double[] newLine, int line)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[line,j] = newLine[j];
            return matrix;
        }
        static sbyte Check1(double[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(0); j++)
                {
                    if(matrix[i,j]==1)
                    {
                        return (sbyte)i;
                    }
                }
            }
            return -1;
        }
        static void WriteMatrix(double[,] matrix, string text="Ваша матрица:")
        {
            int i = 0, j = 0;
            Console.WriteLine("Ваша матрица:");
            for(i = 0; i < matrix.GetLength(0); i++)
            {
                string s = "[";
                for(j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    s += matrix[i,j] + ", ";
                }
                s += matrix[i,j] + "]";
                Console.WriteLine(s);
            }
        }
        static double[] StrToDouble(string[] str)
        {
            double[] nums = new double[str.Length];
            for(int i = 0; i < str.Length;i++)
            nums[i] = Convert.ToDouble(str[i]);
            return nums;
        }
        // static double[,] SortMatrix(double[,] matrix)
        // {
        //     for (int i = 0; i < matrix.GetLength(0)-1; i++) {
        //         if(matrix[i,0] > matrix[i+1,0])
        //         {
        //             double[] temp = new double[matrix.GetLength(1)];
        //             for (int j = 0; j < matrix.GetLength(1); j++)
        //             {
        //                 temp[j] = matrix[i,j];
        //             }
        //             for (int j = 0; j < matrix.GetLength(1); j++)
        //             {
        //                 matrix[i, j] = matrix[i+1,j];
        //                 matrix[i+1,j] = temp[j];

        //             }
        //         }
        //     }
        //     return matrix;
        // }
        static double[,] SolveMatrixGaussMethod(double[,] matrix)
        {
            sbyte check = Check1(matrix);
            if(check != -1)
            {
                // for(int i = 0; i < matrix.GetLength(0); i++)
                // matrix = SortMatrix(matrix);
                matrix = UpdateLineMatrix(matrix, GetLineMatrix(matrix, check), 0);
            }
            int height = matrix.GetLength(0);
            for(int i = 0; i < height-1; i++)
            {
                for(int j = i+1; j < height; j++)
                {
                    matrix = UpdateLineMatrix(
                        matrix,
                        AddLines(
                            MulLine(GetLineMatrix(matrix, i),-1*matrix[j,i]),
                            GetLineMatrix(matrix, j)),
                        j);

                    matrix = UpdateLineMatrix(
                        matrix,
                        DivLine(GetLineMatrix(matrix, i+1), matrix[i+1, i+1]),
                        i+1);
                }
            }
            return matrix;
        }
        static void Main(string[] args)
        {
            int height,width;
            double[,] matrix;
            
            Console.Write("Введите высоту матрицы: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину матрицы: ");
            width = Convert.ToInt32(Console.ReadLine());

            matrix = new double[height,width];
            Console.WriteLine("Параметры текущей матрицы: {0}x{1}\n", matrix.GetLength(0), matrix.GetLength(1));

            //Начинаем заполнять матрицу
            for(int i = 0; i < height; i++)
            {
                Console.Write("[{1}]Введите {0} коэффицента и свободный член через запятую: ", width-1, i+1);
                double[] nums = StrToDouble(Console.ReadLine().Split(","));
                for(int j = 0; j < width; j++)
                {
                    matrix[i,j] = nums[j];
                }
            }
            //WriteMatrix(SortMatrix(matrix), "Сортированная матрица:");
            double[,] result = SolveMatrixGaussMethod(matrix);
            WriteMatrix(result, "Решенная матрица");
        }
    }
}
