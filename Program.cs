string choose;
double a;
double b;
do
{
    Console.WriteLine("Выберите один из вариантов:");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    choose = Console.ReadLine();
    switch (choose)
    {
        case "1":
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: ");
            Console.WriteLine(a + b);
            Console.WriteLine("-----");
            break;
        case "2":
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: ");
            Console.WriteLine(a - b);
            Console.WriteLine("-----");
            break;
        case "3":
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: ");
            Console.WriteLine(a * b);
            Console.WriteLine("-----");
            break;
        case "4":
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            if (b != 0.0)
            {
                Console.WriteLine("Ответ: ");
                Console.WriteLine(a / b);
            }
            else
                Console.WriteLine("Деление на 0 невозможно");
            Console.WriteLine("-----");
            break;
        case "5":
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: ");
            Console.WriteLine(Math.Pow(a, b));
            Console.WriteLine("-----");
            break;
        case "6":
            Console.WriteLine("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: ");
            Console.WriteLine(Math.Sqrt(a));
            Console.WriteLine("-----");
            break;
        case "7":
            Console.WriteLine("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: ");
            Console.WriteLine(a / 100);
            Console.WriteLine("-----");
            break;
        case "8":
            Console.WriteLine("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = 1;
            for (double i = 1; i <= a; i++)
            {
                b *= i;
            }
            Console.WriteLine("Ответ: ");
            Console.WriteLine(b);
            Console.WriteLine("-----");
            break;
    }
} while (choose != "9");