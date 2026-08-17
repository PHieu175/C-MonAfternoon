using System.Runtime.Intrinsics.Arm;

internal class Excercise_1
{
    
    public static void Main(string[] args)
    {
        int number1 = 10, number2 = 20; 

        // 1. to Add / Sum Two Numbers.
        int sum = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {sum}");

        // 2. to Swap Values of Two Variables.
        Console.WriteLine($"Before swap number 1 = {number1}, number 2 = {number2}");
        int temp = number1;
        number1 = number2;
        number2 = temp;
        Console.WriteLine($"After swap number 1 = {number1}, number 2 = {number2}");

        // 3. to Multiply two Floating Point Numbers
        float f1 = 3.5f, f2 = 4.7f;
        float f = f1 * f2;
        Console.WriteLine($"{f1}*{f2}={f}");
    
        // 4. to convert feet to meter
        float feet = 3.8f;
        const float rate = 0.3048f;
        float metter = rate * feet;
        Console.WriteLine($"{feet} feet = {metter} metter");

        // 5. to convert Celsius to Fahrenheit and vice versa

        // 6. to find the Size of data types

        // 7. to Print ASCII Value (tip: read character, print number of this char)

        // 8. to Calculate Area of Circle

        // 9. to Calculate Area of Square

        // 10. to convert days to years, weeks and days

        Console.ReadKey();

    }
}