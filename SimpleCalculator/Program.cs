namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Calculator calculator = new Calculator();
            calculator.Add(5, 3);
            calculator.Subtract(5, 3);  
            calculator.Multiply(5, 3);  
            calculator.Divide(5, 0);    
            calculator.Multiply(5, 1);
            Console.ReadLine();
        }
    }
}
