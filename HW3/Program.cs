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
        char ch;
        int quadLenght;

        /*Напишите метод, который отображает квадрат из
        некоторого символа. Метод принимает в качестве параметра: 
        длину стороны квадрата, символ.*/
        public void quadDrow(char ch, int qL)
        {

            if (quadLenght == 1) Console.WriteLine(ch);
            else
            {
                for (int i = 0; i < qL; i++) { Console.Write(ch.ToString()); };
                Console.WriteLine();
                for (int i = 0; i < qL - 2; i++)
                {
                    Console.Write(ch);
                    for (int j = 0; j < qL - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(ch);
                }
                for (int i = 0; i < qL; i++) { Console.Write(ch.ToString()); };
                Console.WriteLine();
            }
        }

        public void StartTask1()
        {
            Console.WriteLine("введите символ границ фигуры");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("введите длину границ фигуры");
            quadLenght = Convert.ToInt32(Console.ReadLine());
            if (quadLenght <= 1) quadLenght = 1;
            Console.WriteLine();
            quadDrow(ch, quadLenght);
        }
    }
    class Task2
    {
        /*Напишите метод, который проверяет является ли
        переданное число «палиндромом». Число передаётся в
        качестве параметра. Если число палиндром нужно вер-
        нуть из метода true, иначе false.*/
        string p;
        public bool polindrom(string p)
        {
            for (int i = 0, j= p.Length; i < p.Length; i++,j--)
            {
                if (p[i] != p[j-1]) return false;
            }

            return true;
        }

        public void StartTask2()
        {
            Console.WriteLine("введите целое число (палиндром или нет):");
            p = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(polindrom(p));
        }
    }
    class Task3
    {
        /*Напишите метод, фильтрующий массив на основании
        переданных параметров. Метод принимает параметры:
        оригинальный_массив, массив_с_данными_для_филь-
        трации.Метод возвращает оригинальный массив без элемен-
        тов, которые есть в массиве для фильтрации.*/

        string startStr, filtrStr;
        int[] startArr, filtrArr, resultArr;

        
        public void StartTask3()
        {
            Console.WriteLine("введите массив значений через пробел):");
            startStr = Console.ReadLine();
            if (startStr == "") startStr = "0";
            Console.WriteLine("введите фильтр массив значений через пробел):");
            filtrStr = Console.ReadLine();
            if (filtrStr == "") filtrStr = "0";

            string[] strArr = startStr.Split(" ".ToCharArray());
            startArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.Write(startArr[i] = int.Parse(strArr[i]));
                Console.Write(" ");
            }
            Console.WriteLine("<- исходный массив");
            Console.WriteLine();
            

            string[] filArr = filtrStr.Split(" ".ToCharArray());
            filtrArr = new int[filArr.Length];
            for (int i = 0; i < filArr.Length; i++)
            {
                Console.Write(filtrArr[i] = int.Parse(filArr[i]));
                Console.Write(" ");
            }
            Console.WriteLine("<- массив фильтр");
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < startArr.Length; i++)
            {
                for (int j = 0; j < filtrArr.Length; j++)
                {
                    if (startArr[i] == filtrArr[j])
                    { 
                        count++;
                        break;
                    }
                }
            }
            resultArr = new int[startArr.Length - count];
            
            for (int i = 0, ii=0; i <  resultArr.Length; i++,ii++)
            {
                bool flag = false;
                for (int j = 0; j < filtrArr.Length; j++)
                {
                    if (startArr[ii] == filtrArr[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag) ii++;
                resultArr[i]= startArr[ii];
            }
            foreach(var i in resultArr)
            { 
                Console.Write(i+" ");
            }
            Console.WriteLine("<- результат");
            Console.ReadLine();
        }
    }
    class Task4
    {
        /*Создайте класс «Веб-сайт». Необходимо хранить в 
        полях класса: название сайта, путь к сайту, описание 
        сайта, ip адрес сайта. Реализуйте методы класса для ввода 
        данных, вывода данных, реализуйте доступ к отдельным 
        полям через методы класса. */
        
        string nameOfSite, pathOfSite, descripOfSite, ipOfSite;
        // блок ввода
        public void setName() 
        {
            Console.WriteLine("enter name of site");
            this.nameOfSite=Console.ReadLine();
        }

        public void setPath() 
        {
            Console.WriteLine("enter path of site");
            this.pathOfSite=Console.ReadLine();
        }
        public void setDescription() 
        {
            Console.WriteLine("enter description of site");
            this.descripOfSite=Console.ReadLine();
        }
        public void setIp() 
        {
            Console.WriteLine("enter ip of site");
            this.ipOfSite=Console.ReadLine();
        }
       

        //блок вывода
         public string getName() 
        {
            Console.WriteLine($"name of site {this.nameOfSite}");
            return this.nameOfSite;
        }

        public string getPath() 
        {
            Console.WriteLine($"path of site {this.pathOfSite}");
            return this.pathOfSite;
        }
        public string getDescription() 
        {
            Console.WriteLine($"description of site {this.descripOfSite}");
            return this.descripOfSite;
        }
        public string getIp() 
        {
            Console.WriteLine($"ip of site {this.ipOfSite}");
            return this.ipOfSite;
        }

        public void StartTask4()
        {
            int key;
            do 
            { 
                 Console.WriteLine("записать:\n\tназвание - 1 \n\tпуть - 2 \n\tописание - 3\n\tip - 4"+
                     "\nпрочитать:\n\tназвание - 5 \n\tпуть - 6 \n\tописание - 7\n\tip - 8");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        setName();
                        break;
                    case 2:
                        setPath();
                        break;
                    case 3:
                        setDescription();
                        break;
                    case 4:
                        setIp();
                        break;
                    case 5:
                        getName();
                        break;
                    case 6:
                        getPath();
                        break;
                    case 7:
                        getDescription();
                        break;
                    case 8:
                        getIp();
                        break;

                    default:
                        break;
                }
            }while (key>=1);
        }
    }
    
    
   
    class Task5_market
    {
        /*Создайте класс «Магазин». Необходимо хранить в 
        полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail. 
        Реализуйте методы класса для ввода данных, вывода 
        данных, реализуйте доступ к отдельным полям через 
        методы класса. продать товар, принять товар
        класс товар имя, цена*/
        string name;
        string path;
        string descrip;
        string tel;
        string e-mail;
        double balance=0;
        
        //вложеный класс товар
        class Product 
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public double price { get; set; }

            Product() 
            {
                this.Name = "prod0";
                this.price = 0.0;
                this.Description = "something virtual values";
            }
        }

        Product []product= new Product[1];

        public void acceptProduct() 
        {

        }

        public void StartTask5()
        {

        }
    }
    
    class HomeWork
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 - задача 1\n2 - задача 2\n3 - задача 3\n" +
                "4 - задача 4\n5 - задача 5");
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
                
                default:
                    break;

            }
        }
    }
}
