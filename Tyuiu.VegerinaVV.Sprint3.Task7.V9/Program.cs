using Tyuiu.VegerinaVV.Sprint3.Task7.V9.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Вегерина В.В. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнила: Вегерина Виктория Вячеславовна | ИИПб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
        Console.WriteLine("*        (2*x - 3)                                                        *");
        Console.WriteLine("* F(x)= ------------ +5*x-sin(x) (произвести табулирование) f(x) на       *");
        Console.WriteLine("*       cos(x) - 2*x                                                      *");
        Console.WriteLine("* заданном диапазоне [-5;5] с шагом 1.Произвести проверку деления на ноль.*");
        Console.WriteLine("* При делении на ноль вернуть значение 0. Значения округлить до двух      *");
        Console.WriteLine("* знаков после запятой.                                                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] valueArray;
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|     X    +   f(x)   +");
        Console.WriteLine("+----------+----------+");

        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}     |  {1, 6:f2}  |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+----------+----------+");
        Console.ReadKey();
    }
}