using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]{
               { 1, 2, 3, 4, 5, 6, 7, 8 },
               { 8, 7, 6, 5, 4, 3, 2, 1},
               { 2, 3, 4, 5, 6, 7, 8, 9 },
               { 9, 8, 7, 6, 5, 4, 3, 2},
               { 1, 3, 5, 7, 9, 7, 5, 3},
               { 3, 1, 5, 3, 2, 6, 5, 7},
               { 1, 7, 5, 9 ,7 ,3 ,1, 5 },
               { 2,6, 3, 5, 1, 7, 3, 2}
            };
            //Console.WriteLine("Задачи Артема");
            //int[,] k = VozvedenievKvadrat(array);
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(k[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("--------------");
            //int[,] ex2 = ChetVKv(array);
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(ex2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("--------------");
            //int[,] ex3 = Menshe5(array);
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(ex3[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("--------------");
            //int[,] ex4 = Perv4(array);
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(ex4[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine("Задачи Игоря");
            Console.WriteLine("Введите строку матрицы:");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] Igor11 = DeleteRow(array, row);
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(Igor11[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Введите столбец матрицы:");
            int сol = Convert.ToInt32(Console.ReadLine());
            int[,] Igor22 = DeleteCol(array, сol);
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(Igor22[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------");
            //int[,] delete = DeleteAll(array);
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(delete[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine("----------------");
            int[,] swapp = Swap(array);
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(swapp[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
        /// <summary>
        ///  1. Напишите функцию возведения всех элементов матрицы в квадрат. 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int[,] VozvedenievKvadrat(int[,] array)
        {
           
            for (int i = 0; i < 8; i++)
            {
             
                for (int j = 0; j < 8; j++)
                {
                    array[i,j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
                    
                   
                    
                }
               
            }
            return array;
        }
        /// <summary>
        ///   2. Напишите функцию возведения всех четных элементов в квадрат. 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int[,] ChetVKv(int[,] array)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        array[i,j]= Convert.ToInt32(Math.Pow(array[i, j], 2));
                    }
                }
            }
            return array;
        }
        /// <summary>
        ///  3. Напишите функцию возведения в квадрат всех элементов меньше 5. 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int[,] Menshe5(int[,] array)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (array[i, j] < 5)
                    {
                        array[i,j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
                    }
                }
            }
            return array;
        }
        /// <summary>
        ///  4. Напишите функцию возведения первых четырех строк в квадрат. 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int[,] Perv4(int[,] array)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i < 4)
                    {
                        array[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
                    }                                   
                }
            }
            return array;
        }
        /// <summary>
        ///  1. Пусть пользователь через консоль вводит число. Напишите функцию удаления строки в матрице, чей номер равен введенному числу. 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="row"></param>
        /// <returns>
        /// 
        /// </returns>
        private static int[,] DeleteRow(int[,] array,int row)
        {
            int[,] b = new int[7, 8];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    b[i, j] = array[i, j];
                }
            }
            for (int i = row +1; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    b[i-1, j] = array[i, j];
                }
            }
            return b;
        }
        /// <summary>
        /// 2. Пусть пользователь через консоль вводит число. Напишите функцию удаления столбца в матрице, чей номер равен введенному числу. 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        private static int[,] DeleteCol(int[,] array, int col)
        {
            int[,] b = new int[8, 7];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    
                    b[i, j] = array[i, j];
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j =col+1;  j < 8; j++)
                {
                    b[i, j-1] = array[i, j];
                }
            }
            return b;
        }
        /// <summary>
        ///  3. Напишите функцию очистки матрицы. 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="col"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private static int[,] DeleteAll(int[,] array)
        {
            
            for (int i = 0; i < 8 ; i++)
            {
               
                for (int j = 0; j < 8; j++)
                {
                   array[i,j]=0;
                }
                
            }
            
            return array;
        }
        private static int[,] Swap(int[,] array)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;
            a = array[0,0];
            array[0, 0] = array[0, 7];
            array[0, 7] = a;
            b = array[1,0];
            array[1, 0] = array[1,7];
            array[1, 7] = b;
            c = array[2,0];
            array[2,0] = array[2,7];
            array[2,7] = c;
            d = array[3,0];
            array[3,0] = array[3,7];
            array[3,7] = d;
            e = array[4,0];
            array[4,0] = array[4,7];
            array[4,7] = e;
            f = array[5,0];
            array[5,0] = array[5,7];
            array[5,7] = f;
            g = array[6,0];
            array[6,0] = array[6,7];
            array[6,7] = g;
            h = array[7,0];
            array[7,0] = array[7,7];
            array[7,7] = h;
            
            
            return array;
        }

        }
}
