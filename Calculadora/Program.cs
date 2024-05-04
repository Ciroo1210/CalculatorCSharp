int num1;
int num2;
int result;
char again = 'y';

while (again == 'y') {
    Console.WriteLine("1 add \n2 subtract \n3 multiply \n4 divide");
    string election = Console.ReadLine();
    switch (election)
    {
        case "1":
            add();
            break;
        case "2":
            subtract();
            break;
        case "3":
            multiply();
            break;
        case "4":
            divide();
            break;
        default:
            Console.WriteLine("Invalid Entry");
            break;
    }




    void add()
    {
        Console.WriteLine("Enter the values to add");
        num1 = Int32.Parse(Console.ReadLine());
        num2 = Int32.Parse(Console.ReadLine());
        result = num1 + num2;
        Console.WriteLine(result);
    }
    void subtract()
    {
        Console.WriteLine("Enter the values to subtract");
        num1 = Int32.Parse(Console.ReadLine());
        num2 = Int32.Parse(Console.ReadLine());
        result = num1 - num2;
        Console.WriteLine(result);
    }
    void multiply()
    {
        Console.WriteLine("Enter the values to multiply");
        num1 = Int32.Parse(Console.ReadLine());
        num2 = Int32.Parse(Console.ReadLine());
        result = num1 * num2;
        Console.WriteLine(result);
    }
    void divide()
    {
        Console.WriteLine("Enter the values to split");
        num1 = Int32.Parse(Console.ReadLine());
        num2 = Int32.Parse(Console.ReadLine());
        result = num1 / num2;
        Console.WriteLine(result);
    }
}