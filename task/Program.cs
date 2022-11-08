using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while(true){
                Console.Write("Задача 1.\nЗадайте двумерный массив размером m на n, заполненный случайными вещественными числами\n");
                Console.WriteLine("Задача 2.\nНапишите программу, которая на вход принимает двумерный массив, а также элемент массива и возвращает индекс этого элемента или же указание, что такого элемента нет.");
                Console.WriteLine("Задача 3.\nЗадайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
                Console.WriteLine("Введите номер задачи, которую необходимо решить. Если хотите выйти из программы, напишите 0.\n");
                int num=Convert.ToInt32(Console.ReadLine());
                switch (num){
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        return;
                        break;
                }
            }
        }

        static void Task1(){
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("Введите размерность двухмерного массива m на n (через пробел)");
            string str=Console.ReadLine();
            string[] str_arr=str.Split(' ');
            int size=str_arr.Length;
            if(size!=2){
                return;
            }            
            if(Int32.TryParse(str_arr[0], out int m) && Int32.TryParse(str_arr[1], out int n)){
                double[,] array=new double[m,n];
                array=Random_array_double(m,n);
                Write_matrix_double(array,m,n);
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }


        static double[,] Random_array_double(int row, int col){
            double[,] arr=new double[row,col];
            var rnd=new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i,j]=rnd.Next(1,10) + rnd.NextDouble();
                }
            }
            return arr;
        }

        static int[,] Random_array_int(int row, int col){
            int[,] arr=new int[row,col];
            var rnd=new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i,j]=rnd.Next(1,10);
                }
            }
            return arr;
        }

        static void Write_matrix_double(double[,] arr, int str, int col){
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Write_matrix_int(int[,] arr, int str, int col){
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Task2(){
            Console.WriteLine();
            Console.WriteLine();
           
            Console.WriteLine("Введите размерность двухмерного массива m на n (через пробел)");
            string str=Console.ReadLine();
            string[] str_arr=str.Split(' ');
            if(str_arr.Length!=2){
                return;
            }            
            if(Int32.TryParse(str_arr[0], out int m) && Int32.TryParse(str_arr[1], out int n)){
                int[,] array=new int[m,n];
                for (int i = 0; i < m; i++)
                {
                    Console.WriteLine($"Введите элементы {i+1} строчки через пробел");
                    string str_row=Console.ReadLine();
                    string[] str_arr_row=str_row.Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        array[i,j]=Convert.ToInt32(str_arr_row[j]);
                    }
                }
                Write_matrix_int(array,m,n);
                Console.WriteLine();
                Console.WriteLine($"Введите элемент матрицы, индекс которого хотите узнать)");
                int num = Convert.ToInt32(Console.ReadLine());
                Search_el_matrix(array,num);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void Search_el_matrix(int[,] arr, int el){
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(arr[i,j]==el){
                        Console.WriteLine($"Индекс элемента {el} равен {i},{j}");
                        return;
                    }
                }
            }
            Console.WriteLine($"Элемент {el} не найден");
        }

        static void Task3(){
            Console.WriteLine();
            Console.WriteLine();
           
            Console.WriteLine("Введите размерность двухмерного массива m на n (через пробел)");
            string str=Console.ReadLine();
            string[] str_arr=str.Split(' ');
            int size=str_arr.Length;
            if(size!=2){
                return;
            }            
            if(Int32.TryParse(str_arr[0], out int m) && Int32.TryParse(str_arr[1], out int n)){
                int[,] array=new int[m,n];
                array = Random_array_int(m,n);
                Write_matrix_int(array,m,n);
                Search_ar_ar(array,m,n);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void Search_ar_ar(int[,] arr, int row, int col){
            double sr_ar=0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sr_ar +=arr[j,i];
                }
                sr_ar/=arr.GetLength(0);
                Console.WriteLine($"Для {i}-го столбца среднее значение равно {sr_ar}");
            }
        }
    }
}
