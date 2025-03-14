namespace Calctwo

    // have it have a pref
{
    public class calculate
    {
        public int Calc()
        {
            
            Console.Write("A value: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("B Value: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("multiplication|*|/|+|-|Sr|S|: ");
            string multiplication = Console.ReadLine();

            switch (multiplication)
            {
                case "*":
                    return a * b;
                case "/":
                    
                    if(a == 0 || b == 0 )
                    {
                        Console.WriteLine("syntax error");
                        return 0000;
                        
                    }
                    return a / b;
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "Sr":
                    return a / a;
                case "S":
                    return a * a;
                default:
                    return 0000;







            }


            


        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            calculate calc = new calculate();

            int result = calc.Calc();

            Console.WriteLine(result);



        }
    }
}
