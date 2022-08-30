using System;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using Microsoft.Win32;
using System.Security.Cryptography.X509Certificates;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace hw3
{
    class Task1
    {


        /*Напишите метод, который отображает квадрат из
        некоторого символа. Метод принимает в качестве параметра: 
        длину стороны квадрата, символ.*/
        public void quadDrow() 
        {
            
        }

        public void StartTask1()
        {
            char ch;
            int quadLenght;
            Console.WriteLine("введите символ границ фигуры");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("введите длину границ фигуры");
            quadLenght = Convert.ToInt32(Console.ReadLine());


        }
    }
    class Task2
    {
        /**/
        public void StartTask2()
        {
           
        }
    }
    class Task3
    {
        /**/
        public void StartTask3()
        {
            
        }
    }
    class Task4
    {

        /**/

        public void StartTask4()
        {

        }
    }
    class Task5
    {
        /**/
        public void StartTask5()

        {
            
        }
    }
    class Task6
    {
        /*.*/
        public void StartTask6()
        {
            
        }
    }
    class Task7
    {
        /*
		*/
        public void StartTask7()
        {
            
        }
    }
    class HomeWork
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 - задача 1\n2 - задача 2\n3 - задача 3\n" +
                "4 - задача 4\n5 - задача 5\n6 - задача 6\n7 - задача 7");
            Int32 key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Task1 task1 = new Task1();
                    task1.StartTask1();
                    break;
                case 2:
                    Task2 task2 = new Task2();
                    task2.StartTask2();
                    break;
                case 3:
                    Task3 task3 = new Task3();
                    task3.StartTask3();
                    break;
                case 4:
                    Task4 task4 = new Task4();
                    task4.StartTask4();
                    break;
                case 5:
                    Task5 task5 = new Task5();
                    task5.StartTask5();
                    break;
                case 6:
                    Task6 task6 = new Task6();
                    task6.StartTask6();
                    break;
                case 7:
                    Task7 task7 = new Task7();
                    task7.StartTask7();
                    break;

                default:
                    break;

            }
        }
    }
}
