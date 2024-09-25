namespace Topic_3_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomNumber, gradYear;
            double price, radius;
            string courseName, fullName;

            radius = 5;
            gradYear = 2026;
            fullName = "Bailey Hines";
            roomNumber = 29;
            price = 2.99;
            courseName = "Computer Science";

            Console.WriteLine("This is room #" + roomNumber + ".");
            Console.WriteLine("The price is " + price.ToString("C") + ".");
            Console.WriteLine("I am learning more about " + courseName + "!");

            Console.WriteLine("My full name is " + fullName + " and I will graduate in " + gradYear + ".");

            Console.WriteLine("The area of a circle with the radius of 5m is " + (3.14 * (radius * radius)) + " meters squared.");

            
        }
    }
}
