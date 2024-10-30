using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onwir
{
    class work
    {
        public void write_FIO(List<string> lst, int one, int two, int three)
        {
            Console.WriteLine("\nЧто именно вывести?   (имя/фамилию/отчество/всё)");
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "имя":
                    Console.WriteLine(lst[two]);
                    break;
                case "фамилию":
                    Console.WriteLine(lst[one]);
                    break;
                case "отчество":
                    Console.WriteLine(lst[three]);
                    break;
                case "всё":
                    for (int i = 0; i < lst.Count; i++)
                    {
                        Console.Write($"{lst[i]} ");
                    }
                    Console.WriteLine(" ");
                    break;
                case "счёт":
                    Console.WriteLine($"{one}, {two}, {three}");
                    break;
                default:
                    Console.WriteLine("\nТакого нет");
                    break;
            }
        }

        public void rewrite(List<string> lst, int one, int two, int three)
        {
            Console.WriteLine("\nИзменить всё?   (да/нет)");
            string chose = Console.ReadLine();

            if (chose == "нет")
            {
                Console.WriteLine("\nЧто именно изменить?   (имя/фамилию/отчество)");
                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "имя":
                        lst[two] = Console.ReadLine();
                        break;
                    case "фамилию":
                        lst[one] = Console.ReadLine();
                        break;
                    case "отчество":
                        lst[three] = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("\nТакого нет");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nИзмените:");
                for (int i = 0; i < lst.Count; i++)
                {
                    lst[i] = Console.ReadLine();
                }
            }
        }

        
        public void sort_(List<string> lst, ref int one, ref int two, ref int three)
        {
            Console.WriteLine("\nКак сортировать?\t (по возрастанию/убыванию)");
            string choose = Console.ReadLine();

            int grant = 0;

            switch (choose)
            {
                case "по возрастанию":
                    one = lst[one].Length;
                    two = lst[two].Length;
                    three = lst[three].Length;

                    lst.Sort();
                    //Console.WriteLine($"{one}, {two}, {three}");

                    while (grant < 3)
                    {
                        if (lst[grant].Length == one) { one =  grant; }
                        else if (lst[grant].Length == two) { two = grant; }
                        else if (lst[grant].Length == three) { three = grant; }
                        //Console.Write($"{lst[grant].Length}, ");
                        grant++;
                    }
                    //Console.WriteLine($"{one}, {two}, {three}");
                    Console.WriteLine("\nСортировка завершена\n");
                    break;
                case "по убыванию":
                    one = lst[one].Length;
                    two = lst[two].Length;
                    three = lst[three].Length;

                    lst.Sort();
                    lst.Reverse();

                    while (grant < 3)
                    {
                        if (lst[grant].Length == one) { one = grant; }
                        else if (lst[grant].Length == two) { two = grant; }
                        else if (lst[grant].Length == three) { three = grant; }
                        //Console.Write($"{lst[grant].Length}, ");
                        grant++;
                    }

                    Console.WriteLine("\nСортировка завершена\n");
                    break;
                default:
                    Console.WriteLine("\nТакого нет");
                    break;
            }
        }

        public void del(List<string> lst, int one, int two, int three)
        {
            Console.WriteLine("\nЧто именно удалить?   (имя/фамилию/отчество/всё))");
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "имя":
                    lst.RemoveAt(two);
                    break;
                case "фамилию":
                    lst.RemoveAt(one);
                    break;
                case "отчество":
                    lst.RemoveAt(three);
                    break;
                case "всё":
                    lst.Clear();
                    break;
                default:
                    Console.WriteLine("\nТакого нет");
                    break;
            }
        }


        public void fnd(List<string> lst)
        {
            Console.WriteLine("\nПроверка значение не наличие. Введите слово, которое хотите проверить на наличие");
            string choose = Console.ReadLine();

           if (lst.Contains(choose) == true)
            {
                Console.WriteLine("\nТакое слово есть в наличии");
            }
           else
            {
                Console.WriteLine("\nТакого слова нет в списке");
            }
           
        }

    }
}
