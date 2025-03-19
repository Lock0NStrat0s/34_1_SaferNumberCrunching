namespace _34_SaferNumberCrunching;

internal class Program
{
    static void Main(string[] args)
    {
        int num;
        do
        {
            Console.Write("Enter an int: ");
        } while (!int.TryParse(Console.ReadLine(), out num));
        Console.WriteLine(num);

        double numD;
        do
        {
            Console.Write("Enter a double: ");
        } while (!double.TryParse(Console.ReadLine(), out numD));
        Console.WriteLine(numD);

        bool valB;
        do
        {
            Console.Write("Enter a bool: ");
        } while (!bool.TryParse(Console.ReadLine(), out valB));
        Console.WriteLine(valB);
    }
}
