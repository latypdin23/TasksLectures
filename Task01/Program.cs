using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Задание 1
            Console.WriteLine("#1");
            Console.WriteLine(Math.E);*/

            /*//Задание 2
            Console.WriteLine("#2");
            Console.WriteLine(50 + "\n" + 10);*/

            /*//Задание 3
            Console.WriteLine("#3");
            Random random = new Random();
            Console.WriteLine(random.Next() + "\n" + random.Next() + "\n" + random.Next() + "\n" + random.Next());*/

            /*//Задание 4
            Console.WriteLine("#4");
            Console.WriteLine("Введите целое число:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number + 10);*/

            /*//Задание 5
            Console.WriteLine("#5");
            Console.WriteLine("Введите сторону квадрата:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Периметр=" + (a * 4));*/

            /* //Задание 6
             Console.WriteLine("#6");
             Console.WriteLine("Введите радиус окружности:");
             int r = int.Parse(Console.ReadLine());
             Console.WriteLine("Длина=" + (2 * Math.PI * r));
             Console.WriteLine("Площадь=" + (Math.PI * r * r));*/

            /*//Задание 7
            Console.WriteLine("#7");
            Console.WriteLine("Введите x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("y=" + Math.Cos(x));*/

            /*//Задание 8
            Console.WriteLine("#8");
            Console.WriteLine("Введите основание трапеции a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите основание трапеции b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите основание трапеции h:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь=" + (0, 5 * (a + b) * h));*/

            /*//Задание 9
            Console.WriteLine("#9");
            Console.WriteLine("Введите стоимость конфет:");
            double costKonfet = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость печенья:");
            double costPechenie = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость яблок:");
            double costApple = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите z:");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine("Сумма покупки=" + (costKonfet * x + costPechenie * y + costApple * z));*/

            /*//Задание 10
            Console.WriteLine("#10");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир\n\tТруд\n\t\tМай");*/

            /*//Задание 11
            Console.WriteLine("#11");
            double d1, d2;
            int a1, a2;
            string firstDigit, secondDigit;
            firstDigit = Console.ReadLine();
            if (firstDigit != null && firstDigit.Contains(",") || firstDigit != null && firstDigit.Contains(".")) // дроби
            {
                if (firstDigit.Contains("."))
                {
                    firstDigit = firstDigit.Replace('.', ',');
                }
                d1 = double.Parse(firstDigit);
            }
            else
            {
                if (int.TryParse(firstDigit, out a1))//простое число
                {
                    d1 = (double)a1;
                }
                else
                {
                    Console.WriteLine("это не число");
                }
            }*/

            /*//Задание 12
            Console.WriteLine("#12");
            Console.Write("Выберите фигуру: (треугольник(введите т), четырехугольник(введите ч), круг)(введите к): ");
            string figure = Console.ReadLine();

            Console.Write("Выберите искомую величину: площадь(введите s), периметр(введите p): ");
            string value = Console.ReadLine();

            Console.Write("Введите сторону а ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону b ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону c ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону d ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту h ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите радиус r ");
            double r = Convert.ToDouble(Console.ReadLine());

            switch (figure)
            {
                case "т":
                    if (value == "s")
                    {
                        double st = a * h / 2;
                        Console.WriteLine("Площадь треугольника " + st);
                        Console.WriteLine("Искомые величины других фигур: ");
                        double sq = a * h;
                        Console.WriteLine("Площадь четырехугольника " + sq);
                        double sc = 3.14 * r * r;
                        Console.WriteLine("Площадь круга " + sc);
                    }
                    if (value == "p")
                    {
                        double pt = a + b + c;
                        Console.WriteLine("Периметр треугольника " + pt);
                        Console.WriteLine("Искомые величины других фигур: ");
                        double pq = a + b + c + d;
                        Console.WriteLine("Периметр четырехугольника " + pq);
                        double pc = 2 * 3.14 * r;
                        Console.WriteLine("Периметр круга " + pc);
                    }
                    break;
                case "ч":
                    if (value == "s")
                    {
                        double sq = a * h;
                        Console.WriteLine("Площадь четырехугольника " + sq);
                        Console.WriteLine("Искомые величины других фигур: ");
                        double st = a * h / 2;
                        Console.WriteLine("Площадь треугольника " + st);
                        double sc = 3.14 * r * r;
                        Console.WriteLine("Площадь круга " + sc);
                    }
                    if (value == "p")
                    {
                        double pq = a + b + c + d;
                        Console.WriteLine("Периметр четырехугольника " + pq);
                        Console.WriteLine("Искомые величины других фигур: ");
                        double pt = a + b + c;
                        Console.WriteLine("Периметр треугольника " + pt);
                        double pc = 2 * 3.14 * r;
                        Console.WriteLine("Периметр круга " + pc);
                        Console.WriteLine("Искомые величины других фигур: ");
                    }
                    break;
                case "к":
                    if (value == "s")
                    {
                        double sc = 3.14 * r * r;
                        Console.WriteLine("Площадь круга " + sc);
                        Console.WriteLine("Искомые величины других фигур: ");
                        double st = a * h / 2;
                        Console.WriteLine("Площадь треугольника " + st);
                        double sq = a * h;
                        Console.WriteLine("Площадь четырехугольника " + sq);
                    }
                    if (value == "p")
                    {
                        double pc = 2 * 3.14 * r;
                        Console.WriteLine("Периметр круга " + pc);
                        Console.WriteLine("Искомые величины других фигур: ");
                        double pt = a + b + c;
                        Console.WriteLine("Периметр треугольника " + pt);
                        double pq = a + b + c + d;
                        Console.WriteLine("Периметр четырехугольника " + pq);
                    }
                    break;
                default:break;
            }*/
            /*//Задание 13
            Console.WriteLine("#13");
            int number= int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели число {0}", number);*/

            /*//Задание 14
            Console.WriteLine("#14");
            Console.WriteLine("2 кг \n13 17");*/

            /*//Задание 15
            Console.WriteLine("#15");
            Random random = new Random();
            Console.WriteLine(random.Next() + "\n" + random.Next() + "\n" + random.Next() + "\n" + random.Next()); */

            /*//Задание 16
            Console.WriteLine("#16");
            Console.Write("Введите а ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите с ");
            double c = Convert.ToDouble(Console.ReadLine());
            double discr = b * b - 4 * a * c;
            if (discr > 0)
            {
                double x1 = (-b + Math.Sqrt(discr)) / 2 * a;
                double x2 = (-b - Math.Sqrt(discr)) / 2 * a;
                Console.WriteLine($"Корни уравнения {x1} и {x2}");
            }
            else if (discr == 0)
            {
                double x = (-b) / 2 * a;
                Console.WriteLine($"Корень уравнения {x}");
            }
            else
            {
                Console.WriteLine($"Нет действительных корней");
            }*/

            /*//Задание 17
            Console.WriteLine("#17");
            int a = 12;
            int b = 16;
            double armean = (a + b) / 2;
            double geomean = Math.Sqrt(a * b);
            Console.WriteLine($"Среднее арифметическое {a} и {b} равно {armean}, среднее геометерическое равно {geomean}"); */

            /*//Задание 18
            Console.WriteLine("#18");
            double ax = 3;
            double ay = 4;
            double bx = 5;
            double by = 10;
            double r = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
            Console.WriteLine($"Расстоние между точкой А({ax},{ay}) и точкой В ({bx},{by}) равно {r}"); */

            /*//Задание 19
            Console.WriteLine("#19");
            int a = 10,b = 50, c = 100;
            Console.WriteLine($"Сначала а={a}, b={b}, c={c}");

            Console.WriteLine("Задание 19.1");
            int n1 = b;
            b = c;
            int n2 = a;
            a = n1;
            c = n2;
            Console.WriteLine($"После обмена а={a}, b={b}, c={c}");

            Console.WriteLine("Задание 19.2");
            int nn1 = b;
            b = a;
            int nn2 = c;
            c = nn1;
            a = nn2;
            Console.WriteLine($"После обмена а={a}, b={b}, c={c}");*/

            /*//Задание 20
            Console.WriteLine("#20");
            int n = 12672;
            int h = n / 3600;
            int m = (n - 3600 * h) / 60;
            int s = n - 3600 * h - m * 60;
            Console.WriteLine($"С начала суток прошло {n} секунд, с начала суток прошло {h} полных часов, с начала очередного часа прошло {m} полных минут, с начала очередной минуты прошло {s} полных секунд");*/

            /*//Задание 21
            Console.WriteLine("#21");
            int a21 = 543;
            int b21 = 130;
            int d = a21 / b21;
            Console.WriteLine($"Можно отрезать {d} квадрата(ов)");*/

            /*//Задание 22
            Console.WriteLine("#22");
            double a = 123;
            double c = a % 10;
            double numb1 = c * 100;
            double numb2 = Math.Truncate(a / 100);
            double numb3 = a - 100 * numb2;
            double numb4 = (numb3 - c) / 10;
            double n = numb1 + 10 * numb2 + numb4;
            Console.WriteLine($"Начальное число {a}, преобразованное число {n}"); */

            //Задание 23
            /*Console.WriteLine("#23");
            int n = 12557395;
            int thousand = n / 1000;
            int hundred = (n - 1000 * thousand) / 100;
            Console.WriteLine($"У числа {n} {thousand} тысяч {hundred} сотен");*/

            //Задание 24
            /*Console.WriteLine("#24");
            int a = 1234;
            Console.WriteLine("Начальное число " + a); 
 
            Console.WriteLine("Задание 24.1");
            int n1 = a % 10;
            int n2 = a % 100 - n1;
            int n3 = a % 1000 - n1 - n2;
            int n4 = (a % 10000 - n1 - n2 - n3) / 1000;
            int n = n1 * 1000 + n2 * 10 + n3 / 10 + n4;
            Console.WriteLine("Преобразованное число " + n);

            Console.WriteLine("Задание 24.2");
            int n1 = a % 10;
            int n2 = a % 100 - n1;
            int n3 = a % 1000 - n1 - n2;
            int n4 = (a % 10000 - n1 - n2 - n3) / 1000;
            int n = n3 * 10 + n4 * 100 + n1 * 10 + n2 / 10;
            Console.WriteLine("Преобразованное число " + n); 

            Console.WriteLine("Задание 24.3");
            int n1 = a % 10;
            int n2 = a % 100 - n1;
            int n3 = a % 1000 - n1 - n2;
            int n4 = (a % 10000 - n1 - n2 - n3);
            int n = n4 + n2 * 10 + n3 / 10 + n1;
            Console.WriteLine("Преобразованное число " + n);

            Console.WriteLine("Задание 24.4");
            int n1 = a % 10;
            int n2 = a % 100 - n1;
            int n3 = a % 1000 - n1 - n2;
            int n4 = (a % 10000 - n1 - n2 - n3) / 1000;
            int n = n2 * 100 + n1 * 100 + n4 * 10 + n3 / 100;
            Console.WriteLine("Преобразованное число " + n);*/

            /*//Задание 25
            Console.WriteLine("#25");
            int n = 312;
            Console.WriteLine("Преобразованное число " + n);
            int n1 = n / 100;
            int n2 = n - n1 * 100;
            int x = n2 * 10 + n1;
            Console.WriteLine("Начальное число " + x);*/

            /*//Задание 26
            Console.WriteLine("#26");
            int h = 6;
            int m = 0;
            int s = 0;
            double angle = h * 30 + m * 0.5 + s / 120;
            if (angle > 360 | angle == 360)
            {
                angle -= 360;
            }
            Console.WriteLine($"Угол между положением часовой стрелки в начале суток и в указанный момент времени равен {angle} градусов ");*/

            /*//Задание 27
            Console.WriteLine("#27");
            double y = 2; 
            double clockwise = 57.3 * y;
            int h = Convert.ToInt16(Math.Truncate(clockwise / 30));
            double m1 = clockwise - h * 30;
            double m2 = m1 * 2;
            double m3 = m2 * 6;
            int m = Convert.ToInt32(m2);*/

            /*//Задание 28
            Console.WriteLine("#28");
            Console.Write("Введите первое число ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число ");
            double n3 = Convert.ToDouble(Console.ReadLine());
            if ((Math.Abs(n1) < Math.Abs(n2)) && (Math.Abs(n1) < Math.Abs(n3)))
            {
                Console.WriteLine($"Меньшее по модулю из {n1}, {n2} и {n3} это {n1}");
            }
            if ((Math.Abs(n2) < Math.Abs(n1)) && (Math.Abs(n2) < Math.Abs(n3)))
            {
                Console.WriteLine($"Меньшее по модулю из {n1}, {n2} и {n3} это {n2}");
            }
            if ((Math.Abs(n3) < Math.Abs(n1)) && (Math.Abs(n3) < Math.Abs(n2)))
            {
                Console.WriteLine($"Меньшее по модулю из {n1}, {n2} и {n3} это {n3}");
            }*/

            /*//Задание 29
            Console.WriteLine("#29");
            int a = 2;
            int b = 13;
            int c = -4;
            int max = -100;
            int min = 100;

            if (a > max)
            { max = a; }
            if (b > max)
            { max = b; }
            if (c > max)
            { max = c; }

            if (a < min)
            { min = a; }
            if (b < min)
            { min = b; }
            if (c < min)
            { min = c; }

            Console.WriteLine("сумму большего и меньшего из трёх заданных чисел " + (max + min));*/

            /*//Задание 30
            Console.WriteLine("#30");
            int n = 46889;
            int j = 0;
            for (int i = 1; i < n + 1; i++)
            {
                if (n % i == 0)
                {
                    j++;
                }
            }
            Console.WriteLine($"У числа {n} {j} делителей ");*/

            /*//Задание 31
            Console.WriteLine("#31");
            Console.Write("Введите а ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите d ");
            double d = Convert.ToDouble(Console.ReadLine());
            for (int x = -100; x < 101; x++)
            {
                if (a * x * x * x + b * x * x + c * x + d == 0)
                {
                    Console.Write("Корень уравнения = " + x);
                    Console.WriteLine();
                }
            }*/

            /*//Задание 32
            Console.WriteLine("#32");
            int a1 = 2;
            int a2 = 4;
            int d = a2 - a1;
            Console.Write("Введите порядковый номер члена ");
            int n = Convert.ToInt32(Console.ReadLine());
            int an = a1 + d * (n - 1);
            Console.WriteLine($"а{n} = {an}");*/

            /*// Задание 33
             Console.Write("Вы пенсионер и студент? (да/нет) ");
             string not = Console.ReadLine();
            if (not == "нет")
            {
                Console.Write("Введите свой статус: пенсионер(введите п), студент(введите с), работающий(введите р), бомж(введите б), неработающий(введите н) ");
                string status = Console.ReadLine();
                Console.Write("Вы трудоустроены? (да/нет) ");
                string working = Console.ReadLine();
                switch (status)
                {
                    case "п":
                     {
                         if (working == "да")
                         {
                             Console.WriteLine("НЕ видать вам кредита!");
                         }
                         else
                         {
                             Console.WriteLine("Поздравляем!!! Вы можете получить кредит!!!");
                         }
                     }
                        break;
                    case "с":
                     {
                         if (working == "да")
                         {
                             Console.WriteLine("НЕ видать вам кредита!");
                         }
                         else
                         {
                             Console.WriteLine("Поздравляем!!! Вы можете получить кредит!!!");
                         }
                     }
                     break;
                    case "р": Console.WriteLine("НЕ видать вам кредита!"); break;
                    case "б":
                     {
                         if (working == "да")
                         {
                             Console.WriteLine("НЕ видать вам кредита!");
                         }
                         else
                         {
                             Console.WriteLine("Поздравляем!!! Вы можете получить кредит!!!");
                         }
                     }
                     break;
                    case "н":
                     Console.WriteLine("Поздравляем!!! Вы можете получить кредит!!!");
                     break;
             }
            }
            else
            {
                Console.WriteLine("НЕ видать вам кредита!");
            }
            */

            /*//Задание 34
            Console.WriteLine("#34");
            Console.WriteLine("Задание 34.1");
            Console.Write("Введите имя ");
            Console.Write(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Задание 34.2");
            Console.Write("Введите имя ");
            Console.Write("Здравствуйте, " + Console.ReadLine());*/

            /*//Задание 35
            Console.WriteLine("Чтобы начать, напишите приветсвие ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Как тебя зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);
            string s2 = Console.ReadLine();
            Console.WriteLine("Да");
            string s3 = Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            Random color = new Random();
            int c = color.Next(1, 15);
            Console.WriteLine(c);
            ConsoleColor color1 = (ConsoleColor)c;
            Console.BackgroundColor = color1;
            Console.Clear();*/


            /*//Задание 36
            Console.WriteLine("Задание 36.1");
            Random r = new Random();
            int n1 = r.Next(10);
            int n2 = r.Next(10);
            int n3 = r.Next(10);
            int n4 = r.Next(10);
            int n5 = r.Next(10);
            int n6 = r.Next(10);
            int n7 = r.Next(10);
            int n8 = r.Next(10);
            int n9 = r.Next(10);
            int n10 = r.Next(10);
            int n11 = r.Next(10);
            int n12 = r.Next(10);
            int m1 = n2 + n4 + n6 + n8 + n10 + n12;
            int m2 = m1 * 3;
            int m3 = n1 + n3 + n5 + n7 + n9 + n11;
            int m4 = m2 + m3;
            int m5 = m4 % 10;
            int m = 10 - m5;
            Console.WriteLine($"Контрольная цифра штрихкода {n1}{n2}{n3}{n4}{n5}{n6}{n7}{n8}{n9}{n10}{n11}{n12} равна {m}"); 

             Console.WriteLine("Задание 36.2");
             Console.WriteLine("Введите число по цифрам ");
             int n1 = Convert.ToInt32(Console.ReadLine());
             int n2 = Convert.ToInt32(Console.ReadLine());   
             int n3 = Convert.ToInt32(Console.ReadLine());
             int n4 = Convert.ToInt32(Console.ReadLine());
             int n5 = Convert.ToInt32(Console.ReadLine());
             int n6 = Convert.ToInt32(Console.ReadLine());
             int n7 = Convert.ToInt32(Console.ReadLine());
             int n8 = Convert.ToInt32(Console.ReadLine());
             int n9 = Convert.ToInt32(Console.ReadLine());
             int n10 = Convert.ToInt32(Console.ReadLine());
             int n11 = Convert.ToInt32(Console.ReadLine());
             int n12= Convert.ToInt32(Console.ReadLine());
             int m1 = n2 + n4 + n6 + n8 + n10 + n12;
             int m2 = m1 * 3;
             int m3 = n1 + n3 + n5 + n7 + n9 + n11;
             int m4 = m2 + m3;
             int m5 = m4 % 10;
             int m = 10 - m5;
             Console.WriteLine($"Контрольная цифра штрихкода {n1}{n2}{n3}{n4}{n5}{n6}{n7}{n8}{n9}{n10}{n11}{n12} равна {m}");*/

            Console.ReadKey();
        }
    }
}
