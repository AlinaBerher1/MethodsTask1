class Task2
{
    /* Задание 2
Создайте четыре метода для выполнения арифметических операций, с именами: Add – сложение, Sub – 
вычитание, Mul – умножение, Div – деление. Каждый метод должен принимать два целочисленных 
аргумента и выводить на экран результат выполнения арифметической операции соответствующей 
имени метода. Метод деления Div, должен выполнять проверку попытки деления на ноль. 
Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак 
арифметической операции, для выполнения вычислений. */

    static double Add(double number1, double number2)
    {
        double sum = number1 + number2;
        return sum;
    }
    static double Sub (double number1, double number2)
    {
        double substraction = number1 - number2;
        return substraction;
    }
    static double Mul (double number1, double number2)
    {
        double multiplication = number1 * number2;
        return multiplication;
    }
    static double Div (double number1, double number2)
    {
        double division = number1 / number2;
        return division;
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        do
        {
            Console.WriteLine("Пожалуйста, введите первое число:");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите второе число:");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите знак арифметической операции:");
            string sign = Console.ReadLine();
            if (sign == "+")
            {
                double sum = Add(operand1, operand2);
                Console.WriteLine("Сумма чисел - " + sum);
            }
            else if (sign == "-")
            {
                double sub = Sub(operand1, operand2);
                Console.WriteLine("Разница чисел - " + sub);
            }
            else if (sign == "*")
            {
                double mul = Mul(operand1, operand2);
                Console.WriteLine("Произведение чисел - " + mul);
            }
            else if (sign == "/")
            {
                if (operand2 == 0)
                {
                    Console.WriteLine("Нельзя делить на ноль");
                    break;
                }
                else
                {
                    double div = Div(operand1, operand2);
                    Console.WriteLine("Частное чисел - " + div);
                }
            }
            else
            {
                Console.WriteLine("Введите знак арифметической операции (+, -, *, / :");
            }
        }
        while (true);
    }
}