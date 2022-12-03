using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 10
            //int i = 0;
            //int number = 0;
            //while (i < 1)
            //{
            //    Console.WriteLine("Введите трёхзначное число.");
            //    number = int.Parse(Console.ReadLine());
            //    int check = number / 100;
            //    if (check >= 1 && check < 10)
            //    {
            //        check = check * 100;
            //        number = number - check;
            //        number = number / 10;
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Число не трёхзначное, попробуйте снова.");
            //    }
            //}
            //Console.WriteLine(number);

            // Задача 13

            // Хотел сделать возможным выход из программы, путём введения не цифры, а буквы, но у меня не вышло, хотя я помню, что вы об этом рассказывали

            //int i = 0;
            //int number = 0;
            //int d = 0;
            //while (i < 1)
            //{
            //    Console.WriteLine("Введите число:");
            //    number = int.Parse(Console.ReadLine());
            //    if (number > 99){
            //        d = 1;
            //    }
            //    else if(number < 100)
            //    {
            //        d = 2;
            //    }
            //    else
            //    {
            //        d = 3;
            //    }
            //    switch (d)
            //    {
            //        case 1:
            //            Console.WriteLine("Третья цифра "+ number.ToString()[2]);
            //            break;
            //        case 2:
            //            Console.WriteLine("Третьей цифры нет.");
            //            break;
            //        case 3:
            //            i++;
            //            break;

            //    }

            //}

            // Задача 15

            Console.WriteLine("Введите число от 1 до 7:");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Понедельник - день тяжёлый. Не выходной.");
                    break;
                case 2: Console.WriteLine("Кто в понедельник бездельник, тот и во вторник не работник. Не выходной.");
                    break;
                case 3: Console.WriteLine("Среда пришла — неделя прошла. Не выходной.");
                    break;
                case 4: Console.WriteLine("У лжеца на одной неделе семь четвергов. Не выходной.");
                    break;
                case 5: Console.WriteLine("Зарплата в пятницу — удар по печени. Не выходной.");
                    break;
                case 6: Console.WriteLine("Счастья без суббот не бывает. Выходной.");
                    break;
                case 7: Console.WriteLine("Воскресенье — день накануне понедельника, так что он отравлен. Выходной.");
                    break;
                default: Console.WriteLine("Такого дня недели нет, но куда деваться?");
                    break;
            }

//░░░░░░░░░░░░▄▐
//░░░░░░▄▄▄░░▄██▄
//░░░░░▐▀█▀▌░░░░▀█▄
//░░░░░▐█▄█▌░░░░░░▀█▄
//░░░░░░▀▄▀░░░▄▄▄▄▄▀▀
//░░░░▄▄▄██▀▀▀▀
//░░░█▀▄▄▄█░▀▀
//░░░▌░▄▄▄▐▌▀▀▀
//▄░▐░░░▄▄░█░▀▀
//▀█▌░░░▄░▀█▀░▀
//░░░░░░░▄▄▐▌▄▄
//░░░░░░░▀███▀█░▄
//░░░░░░▐▌▀▄▀▄▀▐▄
//░░░░░░▐▀░░░░░░▐▌
//░░░░░░█░░░░░░░░█
//░░░░░▐▌░░░░░░░░░█
//░░░░░█░░░░░░░░░░▐▌


        }
    }
}
