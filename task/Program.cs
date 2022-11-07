using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while(true){
                Console.Write("Задача 1.\nЗадайте двумерный массив размером m×n, заполненный случайными вещественными числами\n");
                Console.WriteLine("Задача 2.\nНапишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.\n");
                Console.WriteLine("Задача 3.\nЗадайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.\n");
                Console.WriteLine("Введите номер задачи, которую необходимо решить. Если хотите выйти из программы, напишите 0.");
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
                int[,] array=new int[m,n];
                Random_array(out array,m,n);
                Write_matrix(array);
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }


        static void Random_array(out int[,] arr, int col, int str){
            var rnd=new Rendom();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i,j]=rnd.Next(1,10) + rnd.NextDouble();
                }
            }
        }

        static void Write_matrix(int[,] arr){
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
