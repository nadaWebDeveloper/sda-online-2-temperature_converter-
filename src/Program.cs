
class Temperature
{
    public static void Main(string[] args)
    {
        double result, option, numb;
        string? temp;
        String[] units = { "F°", "C°", "K°" };

        Console.WriteLine("\t-- Temperature Converter --\nEnter the Temperature you want converted:");
        temp = Console.ReadLine()?.Trim();


        if (double.TryParse(temp, out numb))
        {

            double convertToDouble = Convert.ToDouble(temp);
            Console.WriteLine("\tChoose which One converted:");
            Console.WriteLine("\t1. Fahrenheit To Celsius \n\t2. Celsius To Fahrenheit\n\t3. Celsius To Kelvin\n\t4. Kelvin To Celsius\n\t5. Kelvin To Fahrenheit \n\t6. Fahrenheit To Kelvin\n\t7. Quit");
            Console.Write("Your Option:");
            option = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t-------------------------");

            switch (option)
            {
                case 1:
                    result = ConvertTemp.F_to_C(convertToDouble);
                    Console.Write($"Fahrenheit:{convertToDouble} {units[0]} To Celsius:{result:F3} {units[1]}\n");
                    Console.WriteLine($"Formula Of Temperature: {FormulaTemp.F_to_C_Formula(convertToDouble)}");
                    break;
                case 2:
                    result = ConvertTemp.C_to_F(convertToDouble);
                    Console.Write($"Celsius:{convertToDouble} {units[1]} To Fahrenheit:{result:F3} {units[0]}\n");
                    Console.WriteLine($"Formula Of Temperature: {FormulaTemp.C_to_F_Formula(convertToDouble)}");
                    break;
                case 3:
                    result = ConvertTemp.C_to_K(convertToDouble);
                    Console.Write($"Celsius:{convertToDouble} {units[1]} To kelvin:{result:F3} {units[2]}\n");
                    Console.WriteLine($"Formula Of Temperature: {FormulaTemp.C_to_K_Formula(convertToDouble)}");
                    break;
                case 4:
                    result = ConvertTemp.K_to_C(convertToDouble);
                    Console.Write($"kelvin:{convertToDouble} {units[2]} To Celsius:{result:F3} {units[1]}\n");
                    Console.WriteLine($"Formula Of Temperature: {FormulaTemp.K_to_C_Formula(convertToDouble)}");
                    break;
                case 5:
                    result = ConvertTemp.K_to_F(convertToDouble);
                    Console.Write($"kelvin:{convertToDouble} {units[2]} To Fahrenheit:{result:F3} {units[0]}\n");
                    Console.WriteLine($"Formula Of Temperature: {FormulaTemp.K_to_F_Formula(convertToDouble)}");
                    break;
                case 6:
                    result = ConvertTemp.F_to_K(convertToDouble);
                    Console.Write($"Fahrenheit:{convertToDouble} {units[0]} To kelvin:{result:F3} {units[2]}\n");
                    Console.WriteLine($"Formula Of Temperature: {FormulaTemp.F_to_K_Formula(convertToDouble)}");
                    break;
                case 7:
                    Console.WriteLine($"Program Terminated");
                    break;
                default:
                    Console.WriteLine($"Invalid scale Option");

                    break;

            }


        }
        else
        {
            Console.WriteLine($"Invalid input '{temp}'. Please enter a numeric temperature");
        }

        Console.ReadKey();
    }
}