using System;
using System.Threading;
class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity (int duration) : base (duration,"Breathing", "This activity will help you relax by guiding you while you take deep breathing process"){}
    public void StartBreathing(){
        StartMessage();
        int elapsedTime = 0;
        while(elapsedTime < _duration){
            Console.Write("Inhale a deep breathe...");
            PauseWithAnimation(3);
            elapsedTime +=3;

            Console.Write("Exhale slowly...");
            PauseWithAnimation(3);
            elapsedTime +=3;
        }
        EndMessage("Breathing");
    }
}