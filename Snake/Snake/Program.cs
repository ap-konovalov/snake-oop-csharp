using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();
            
            Point p2 = new Point(4,3,'#');
            p2.Draw();

            Point p3 = new Point(17, 7, '&');

            Point p4 = new Point(11, 2, '@');

            Point p5 = new Point(3, 11, '$');

            Point p6 = new Point(2, 5, '~');

            //создали новый список
            List<int> numList = new List<int>();

            // добавили в список элементы , цифры 0 , 1 и 2
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            // присвоили переменным значения элементов 0 , 1 и 2 из списка
            int x = numList[0];
            int y = numList[1];
            int z = numList[2];  

            // для каждого  элемента списка numList обозначенного условно i сделай...
            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            // удаляет элемент с индексом 0 из списка
            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            pList.Add(p6);

            List<char> pChars = new List<char>();
            pChars.Add('*');
            pChars.Add('#');

            Console.ReadLine();
        }

    }
}
