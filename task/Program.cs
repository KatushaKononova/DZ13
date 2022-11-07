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
                array=Random_array(m,n);
                Write_matrix(array,m,n);
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }


        static double[,] Random_array(int row, int col){
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

        static void Write_matrix(double[,] arr, int str, int col){
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
            int size=str_arr.Length;
            if(size!=2){
                return;
            }            
            if(Int32.TryParse(str_arr[0], out int m) && Int32.TryParse(str_arr[1], out int n)){
                Console.WriteLine($"Введите двухмерный массив {m} на {n} (строчки через пробел, столбцы через enter)");
                double[,] array=new double[m,n];
                for (int i = 0; i < m; i++)
                {
                    string str_row=Console.ReadLine();
                    string[] str_arr_row=str.Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        array[i,j]=Int32.Parse(str_arr_row[j]);
                    }
                }
                Console.WriteLine($"Введите элемент матрицы, индекс которого хотите узнать)");
                int num = Convert.ToInt32(Console.ReadLine());
                Search_el_matrix(array,num);
                //Console.WriteLine($"Индекс элемента {num} равен {index[0]},{index[1]})");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void Task3(){
            Console.WriteLine();
            Console.WriteLine();
           
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
