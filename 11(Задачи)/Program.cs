using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Запрос первого числа
            Console.Write("Введите первое число (от 0 до 10): ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            // Запрос второго числа
            Console.Write("Введите второе число (от 0 до 10): ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Проверка, находятся ли числа в диапазоне от 0 до 10
            if (number1 >= 0 && number1 <= 10 && number2 >= 0 && number2 <= 10)
            {
                // Вычисление произведения и вывод результата
                double product = number1 * number2;
                Console.WriteLine($"Произведение чисел {number1} и {number2} равно {product}");
                break; // Выход из цикла
            }
            else
            {
                // Сообщение о недопустимых числах и повторный запрос
                Console.WriteLine("Введенные числа недопустимы. Пожалуйста, введите числа в диапазоне от 0 до 10.");
            }
        }
    }
}
