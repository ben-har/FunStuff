using System;
//randomly change the letters 
//use the key to dycrpt the letters
//maybe switch around the characters 
public class Program
{
    public static string Rearrange(string input, int n)
    {
        if (input.Length <= n)
        {
            return "string not long enough";
            Console.Write("give a name to encrypt ");
            string UserInput = Console.ReadLine();
            Console.Clear();
        }

        if (input[0] == input[input.Length - 1])
        {
            return "first and last letter are the same";
            Console.Write("give a name to encrypt ");
            string UserInput = Console.ReadLine();
            Console.Clear();
        }

        char firstChar = input[0];
        string middleChar = input.Substring(1, input.Length -2 );
        char lastChar = input[-1];

        string result = firstChar + middleChar + lastChar;
        return result;
        













    }
    public static string MoveOne(string input)
    {
        string result = "";

        foreach (char c in input)
        {
            result += (char)(c + 1);

        }
        return result;


    }
    public static string MoveBack(string input)
    {
        string result = "";
        foreach (char c in input)
        {
            result += (char)(c - 1);

        }
        return result;




    }
    public static void Main()
    {
        //defines user input
        Console.Write("give a name to encrypt ");
        string UserInput = Console.ReadLine();
        Console.Clear();


        //encrypts user input 
        string encrypted = MoveOne(UserInput);
        encrypted = Rearrange(UserInput);
        Console.WriteLine(encrypted);


        //asks user if they would like to decrypt
        Console.Write("would you like to decrypt (yes/no) ");
        string IsON = Console.ReadLine().ToLower();


        //will check if user will like to run the program again 
        if (IsON == "yes")
        {
            string decrypted = MoveBack(encrypted);
            Console.WriteLine(decrypted);
        }
        else
        {

            Console.WriteLine("goodbye");
        }


    }
}