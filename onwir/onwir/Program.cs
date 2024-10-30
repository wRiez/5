using onwir;

work work = new work();
var FIO = new List<string>();

Console.WriteLine("Введите ваше ФИО: ");
for (int i = 0; i < 3; i++)
{
    FIO.Add(Console.ReadLine());
}


int subname = 0;
int name = 1;
int fathername = 2;

string choose = "2";
string start = "E";

switch (start)
{
    case "S":
        switch (choose)
        {
            case "вывести":
                work.write_FIO(FIO, subname, name, fathername);
                break;
            case "изменить":
                work.rewrite(FIO, subname, name, fathername);
                break;
            case "сортировать":
                work.sort_(FIO, ref subname, ref name, ref fathername);
                //Console.WriteLine($"{subname}, {name}, {fathername}");
                break;
            case "удалить":
                work.del(FIO, subname, name, fathername);
                break;
            case "найти":
                work.fnd(FIO);
                break;
            default:
                Console.WriteLine("Некорректный ввод");
                break;
        }
        goto case "E";
    case "E":
        Console.WriteLine("\nВыберите действие с введёнными данными:    Вывести   Изменить  Сортировать  Удалить  Найти");
        choose = Console.ReadLine();
        goto case "S";
}