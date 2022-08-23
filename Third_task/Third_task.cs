Console.Write("Введите цифру дня недели от 1 до 7: ");
int number_days = Int32.Parse(Console.ReadLine());
switch(number_days)
{
    case 1:
        Console.WriteLine("Понедельник рабочий день");
        break;
    case 2:
        Console.WriteLine("Вторник рабочий день");
        break;
    case 3:
        Console.WriteLine("Среда рабочий день");
        break;
    case 4:
        Console.WriteLine("Четверг рабочий день");
        break;
    case 5:
        Console.WriteLine("Пятница рабочий день");
        break;
    case 6:
        Console.WriteLine("Суббота выходной");
        break;
    case 7:
        Console.WriteLine("Воскресенье выходной");
        break;
    default:
        Console.WriteLine("Цифра дня недели введена неверно!");
        break;        
}



