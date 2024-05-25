try
{
    double num1;
    double num2;
    double result;
    char again = 'y';

    while (again == 'y')
    {
        Console.WriteLine("Select an operation: \n1. Add \n2. Subtract \n3. Multiply \n4. Divide \n5. Power \n6. Square Root");
        string election = Console.ReadLine();
        switch (election)
        {
            case "1":
                Add();
                break;
            case "2":
                Subtract();
                break;
            case "3":
                Multiply();
                break;
            case "4":
                Divide();
                break;
            case "5":
                Power();
                break;
            case "6":
                squareRoot();
                break;
            default:
                Console.WriteLine("Invalid input. Please select a valid operation.");
                break;
        }

        void Add()
        {
            Console.WriteLine("Enter the values to add:");
            num1 = Double.Parse(Console.ReadLine());
            num2 = Double.Parse(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("Result: " + result);
            Finish();
        }
        void Subtract()
        {
            Console.WriteLine("Enter the values to subtract:");
            num1 = Double.Parse(Console.ReadLine());
            num2 = Double.Parse(Console.ReadLine());
            result = num1 - num2;
            Console.WriteLine("Result: " + result);
            Finish();
        }
        void Multiply()
        {
            Console.WriteLine("Enter the values to multiply:");
            num1 = Double.Parse(Console.ReadLine());
            num2 = Double.Parse(Console.ReadLine());
            result = num1 * num2;
            Console.WriteLine("Result: " + result);
            Finish();
        }
        void Divide()
        {
            Console.WriteLine("Enter the values to divide:");
            num1 = Double.Parse(Console.ReadLine());
            num2 = Double.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            Finish();
        }
        void Power()
        {
            Console.WriteLine("Enter the base value:");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exponent value:");
            num2 = Double.Parse(Console.ReadLine());
            result = Math.Pow(num1, num2);
            Console.WriteLine("Result: " + result);
            Finish();
        }
        void squareRoot()
        {
            num1 = Double.Parse(Console.ReadLine());
            double result = Math.Sqrt(num1);
            Console.WriteLine(result);
            
            
        }
        void Finish()
        {
            Console.WriteLine("Do you want to continue? (y/n)");
            string continueVar = Console.ReadLine().ToLower();
            if (continueVar == "n")
            {
                again = 'n';
            }
            else if (continueVar == "y")
            {
                again = 'y';
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' to continue or 'n' to exit.");
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}
