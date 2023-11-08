namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");

                // Task 1. Read choice input and assing it to new int variable
                int choice = Convert.ToInt32(Console.ReadLine());

                // Task 2. Check if user selected choice 5. If so then exit the loop
                if (choice == 5)
                {
                    Console.WriteLine("Exiting the program.");
                    return;
                }

                Console.Write("Enter first number: ");
                // Task 3. Get the first number and assing it to new double variable
                double firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                // Task 4. Get the second number and assing it to new double variable
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                // Task 5. Create double variable for default result value and assign it to be 0
                double result = 0;

                // Task 6. Handle choices using switch statement
                // Task 6.1 For each case create new function/method an call it inside the case
                //          - Case 1: Add 
                //          - Case 2: Subtract
                //          - Case 3: Multiply
                //          - Case 4: Divide, Note remeber to handle 0
                // Note: Think what the default choice should be
                // Note: Declare each case function/method outside Main method
                //       There is comment below where you can place your methods
               switch (choice)
                {
                    case 1:
                        result = Add(firstNumber, secondNumber);
                        break;
                    case 2:
                        result = Subtract(firstNumber, secondNumber);
                        break;
                    case 3:
                        result = Multiply(firstNumber, secondNumber);
                        break;
                    case 4:
                        if (secondNumber != 0)
                        {
                            result = Divide(firstNumber, secondNumber);
                        }
                        else
                            Console.WriteLine("Division by zero is not allowed");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }




                // Task 7. Print out the result
                Console.WriteLine("Result:" + " " + result);
            }
        }

        // Declare your methods/functions here
        public static double Add(double first, double second)
        { return first + second; } 

        public static double Subtract(double first, double second)
        { return first - second; }

        public static double Multiply(double first, double second)
        { return first * second; }

        public static double Divide(double first, double second)
        { return first / second; }
    }
}