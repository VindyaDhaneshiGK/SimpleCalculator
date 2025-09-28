namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Calculator calculator = new Calculator();
            Console.WriteLine("Add 5 plus 3 is:"+calculator.Add(5, 3));
            Console.WriteLine("Substract 5 minus 3 is:"+calculator.Subtract(5, 3));
            Console.WriteLine("Multiply 5 by 3 is:" +calculator.Multiply(5, 3));
            Console.WriteLine("Divide 5 from 2 is:" + calculator.Divide(5, 2));
            Console.WriteLine("Multiply 5 by 3 is:" + calculator.Multiply(5, 1));
            Console.ReadLine();
        }
    }
}
