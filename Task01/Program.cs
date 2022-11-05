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

            //Задание 12
            Console.WriteLine("#12");

            /*//Задание 13
            Console.WriteLine("#13");
            int number= int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели число {0}", number);*/

            /*//Задание 14
            Console.WriteLine("#14");
            Console.WriteLine("2 кг \n13 17");*/

            //Задание 15
            Console.WriteLine("#15");
            //Задание 16
            //Задание 17
            //Задание 18

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
            //Задание 25
            //Задание 26
            //Задание 27
            //Задание 28
            //Задание 29
            //Задание 30
            //Задание 31
            //Задание 32

            /*//Задание 33
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

            //Задание 34

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
