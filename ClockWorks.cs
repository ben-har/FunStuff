using System;

public class Clock
{
    private int hours = 24;
    private int minutes = 60;
    private int second = 60;
    private bool clockOn = false;
    public Clock()
    {
    }

    public int Hours
    {
        get { return this.hours; }
        set { this.hours = value; }


    }
    public int Minutes
    {
        get { return this.minutes; }
        set { this.minutes = value; }

    }
    public int Second
    {
        get { return this.second; }
        set { this.second = value; }
    
    
    }
    public bool ClockOn
    {
        set { this.clockOn = value; }
        get { return this.clockOn; }
    }
    public static void Main(string[] args)
    {
        Clock MyClock = new Clock();
        Console.Write("what do you want the hours to be set to ");
        MyClock.Hours = int.Parse(Console.ReadLine());
        Console.Write("what do you want the Minutes to be set to ");
        MyClock.Minutes = int.Parse(Console.ReadLine());
        Console.Write("what do you want the Second to be set to ");
        MyClock.Second = int.Parse(Console.ReadLine());
        

        //asks the user if they want the clock to run 
        Console.Write("do you want the clock to run ");
        MyClock.ClockOn = bool.Parse(Console.ReadLine());
        do
        {
            if (MyClock.Second >= 0)
            {
                Console.WriteLine("hours " + MyClock.Hours + " minutes " + MyClock.Minutes + " Seconds " + MyClock.Second);
                MyClock.Second--;
                Thread.Sleep(1000);
                Console.Clear();
            }
            if (MyClock.Second == 0)
            {
                MyClock.Minutes--;
                
                MyClock.Second = MyClock.Second + 60;




            }
            if (MyClock.Minutes == 0)
            {
                MyClock.Hours--;
                MyClock.Minutes = MyClock.Minutes + 60;





            }
            // a way to fix the negative time is to make it <= 0 instead of ==
            if (MyClock.Second == 0 && MyClock.Minutes == 0 && MyClock.Hours == 0)
            {
                Console.Beep(2000, 2000);
                Console.Write("Do you want the clock to run? ");
                MyClock.ClockOn = bool.Parse(Console.ReadLine());
            }









        }
        while(MyClock.ClockOn);

    }
}
