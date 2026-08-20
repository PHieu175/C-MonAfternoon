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
        Console.WriteLine($"Before swap number 1: = {number1}, number 2 = {number2}");
        int temp = number1;
        number1 = number2;
        number2 = temp;
        Console.WriteLine($"After swap number 1: = {number1}, number 2 = {number2}");

        // 3. to Multiply two Floating Point Numbers
        float f1 = 3.5f, f2 = 4.7f;
        float f = f1 * f2;
        Console.WriteLine($"{f1}*{f2}={f}");
    
        // 4. to convert feet to meter
        float feet = 3.8f;
        const float rate = 0.3048f;
        float meter = rate * feet;
        Console.WriteLine($"{feet} feet = {meter} meter");

        // 5. to convert Celsius to Fahrenheit and vice versa
        float cels = 27f;
        float fah = cels * 1.8f + 32;
        Console.WriteLine($"{cels}°C = {fah}F");

        // 6. to find the Size of data types
        Console.WriteLine($"Size of double data type is {sizeof(double)}");
        Console.WriteLine($"Size of int data type is {sizeof(int)}");
       
        // 7. to Print ASCII Value (tip: read character, print number of this char)
        Console.Write("Enter a single character: ");
        char myChar = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Moves the console cursor to the next line
        int asciiValue = (int)myChar;
        Console.WriteLine($"The ASCII value of '{myChar}' is {asciiValue}"); 

        // THÊM DÒNG NÀY ĐỂ XÓA PHÍM ENTER BỊ KẸT:
        Console.ReadLine(); 

        // 8. to Calculate Area of Circle
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double circleArea = Math.PI * radius * radius;
        Console.WriteLine($"The area of the circle is {circleArea}");

        // 9. to Calculate Area of Square
        Console.Write("Enter the side length of the square: ");
        double side = Convert.ToDouble(Console.ReadLine());
        double squareArea = side * side;
        Console.WriteLine($"The area of the square is {squareArea}");

        // 10. to convert days to years, weeks and days
        Console.Write("Enter the total number of days: ");
        int totalDays = Convert.ToInt32(Console.ReadLine());
        int years = totalDays / 365;
        int remainingDays = totalDays % 365;
        int weeks = remainingDays / 7;
        int days = remainingDays % 7;
        Console.WriteLine($"{totalDays} days is equivalent to {years} years, {weeks} weeks, and {days} days.");

        Console.ReadKey();

    }
}