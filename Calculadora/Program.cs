try
{
    int num1;
    int num2;
    int result;
    char again = 'y';

    while (again == 'y')
    {
        Console.WriteLine("Select an operation: \n1. Add \n2. Subtract \n3. Multiply \n4. Divide");
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
            default:
                Console.WriteLine("Invalid input. Please select a valid operation.");
                break;
        }

        void Add()
        {
            Console.WriteLine("Enter the values to add:");
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("Result: " + result);
            Finish();
        }
        void Subtract()
        {
            Console.WriteLine("Enter the values to subtract:");
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 - num2;
            Console.WriteLine("Result: " + result);
            Finish();
        }
        void Multiply()
        {
            Console.WriteLine("Enter the values to multiply:");
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 * num2;
            Console.WriteLine("Result: " + result);
            Finish();
        }
        void Divide()
        {
            Console.WriteLine("Enter the values to divide:");
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
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
        void Finish()
        {
            Console.WriteLine("Do you want to continue? (y/n)");
            string ContinueVar = Console.ReadLine().ToLower();
            if (ContinueVar == "n")
            {
                again = 'n';
            }
            else if (ContinueVar == "y")
            {
                again = 'y';
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
