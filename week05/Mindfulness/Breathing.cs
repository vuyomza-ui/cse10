using System;

public class BreathingActivity:Activity
{
public BreathingActivity()
:base(
"Breathing",
"This activity will help you relax by walking you through breathing in and out slowly.Clear you mind and focus on your breathing.")    
{

}


    public void Run()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        bool breatheIn = true;

        while (DateTime.Now < endTime)
        {
            if (breatheIn)
            {
                Console.Write("Breathe in...");
            }
            else
            {
                Console.Write("Breathe out...");
            }

            ShowCountDown(4);
            Console.WriteLine();

            breatheIn = !breatheIn;
        }
        EndActivity();
    }
}