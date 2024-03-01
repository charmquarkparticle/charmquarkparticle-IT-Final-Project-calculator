try
{
    Console.WriteLine("Please write the operation correctly: separate numbers and operators.");
    string members = Console.ReadLine();
    

    string[] membersOfTheOperation = members.Split(' ');
    if (membersOfTheOperation.Length != 3)
    {
        throw new FormatException(" Please write the operation correctly: first the number, then the operation and finally the number again.");
    }

    double number1 = double.Parse(membersOfTheOperation[0]);
    string moqmedeba = membersOfTheOperation[1];
    double number2 = double.Parse(membersOfTheOperation[2]);

    double result = 0;

    switch (moqmedeba)
    {
        case "-":
            result = number1 - number2;
            break;
        case "+":
            result = number1 + number2;
            break;
        case "/":
            if (number2 == 0)
            {
                throw new DivideByZeroException("This attempt is invalid, division by zero is not possible.");
            }
            result = number1 / number2;
            break;
        case "*":
            result = number1 * number2;
            break;
        case "%":
            result = number1 % number2;
            break;
        case "%%":
            result = number1 * number2 / 100;
            break;
        default:
            throw new ArgumentException("Invalid operator, please enter one of the given operators! (-, +, /,  *, %, %%)");
    }

    Console.WriteLine($"The result of the operation you entered: {result}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error : {ex.Message}");
}