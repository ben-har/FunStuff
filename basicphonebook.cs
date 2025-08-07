namespace phonenumbers
{
    // allow user to add new contacts and update existing contacts
    // catch duplicate information
    public class myphoneMethods()
    {
        Dictionary<string, long> phonebook = new Dictionary<string, long>();

        // use a switch to have user go through to get what input they want 
        public void Menu()
        {
            Console.WriteLine("welcome to contacts would you like to add,read a contact? ");

            switch(Console.ReadLine())
            {
                case "add":
                    newcontact();
                    break;
                case "read":
                    readContact();
                    break;
                default:
                    Console.WriteLine("sorry that input was invaid ");
                    break;

            }
        }
        void newcontact()
        {
            string username = " ";
            long usernum = 0;
            Console.Write("what is the name that you wanna add ");
            username = Console.ReadLine();
            Console.WriteLine("what is the phone number of the user ");
            usernum = long.Parse(Console.ReadLine());
            phonebook.Add(username, usernum);
            Menu();
        }
        void readContact()
        {
            Console.Write("what is the name of the phone number you wanna find? ");
            //catch to make sure it wont throw a null imput if 
            Console.WriteLine(phonebook[Console.ReadLine()]);
        
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myphoneMethods phonemeth = new myphoneMethods();

            phonemeth.Menu();
        }
    }
}
