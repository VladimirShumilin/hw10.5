using System.Globalization;


Calculator.Calculator calc  = new();

while (true)
    try
    {
        Console.WriteLine("Введите первый параметр для сложения");
        decimal num1 = Convert.ToDecimal(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.WriteLine("Введите второй параметр для сложения");
        decimal num2 = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Сумма: {calc.Add(num1,num2)}") ;

    }
    //Console.ReadLine
    catch (IOException ex) { Console.WriteLine(ex); }
    catch (OutOfMemoryException ex) { Console.WriteLine(ex); }
    catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex); }
    //Convert.ToDecimal
    catch (FormatException ex) { Console.WriteLine(ex); }
    catch (OverflowException ex) { Console.WriteLine(ex); }
