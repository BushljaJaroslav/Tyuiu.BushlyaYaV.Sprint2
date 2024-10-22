
using Tyuiu.BushlyaYaV.Sprint2.Task4.V5.Lib;
namespace Tyuiu.BushlyaYaV.Sprint2.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Бушля Я. В. | ИСТНб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тернарный оператор                                                      *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Бушля Ярослав Владимирович | ИСТНб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу.                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double a, b;

            Console.Write("Введите значение переменной X: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение переменной Y: ");

            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

           
            
            
            var result = ds.Calculate(a, b);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
