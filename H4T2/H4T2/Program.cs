using System;

namespace H4T2
{
    public delegate void AlarmHandler(int timeTick);
    public delegate void TickHandler(int timeTick);
    class ClockEvent
    {
        public event AlarmHandler onAlarm;
        public event TickHandler onTick;
        public void Tick(int timeTick) { onTick(timeTick); }
        public void Alarm(int timeTick) { onAlarm(timeTick); }
    }
    class AlarmClock
    {
        public ClockEvent clock=new ClockEvent();
        private int timeTick;
        public  int TimeTick { get { return timeTick; } set { timeTick = value; } }
        public AlarmClock()
        {
            timeTick = 0;
            clock.onTick += new TickHandler(TickEvent);
            clock.onAlarm += new AlarmHandler(AlarmEvent);
        }
        public void TickEvent(int timeTick)
        {
            Console.WriteLine("Tick at time " + timeTick);
        }
        public void AlarmEvent(int timeTick)
        {
            Console.WriteLine("Alarm !!! now is " + timeTick);
        }
        public void Tick()
        {
            clock.Tick(timeTick);
        }
        public void Alarm()
        {
            clock.Alarm(timeTick);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock Clock1 = new AlarmClock();
            while (Clock1.TimeTick < 20)
            {
                Clock1.TimeTick += 1;
                Clock1.Tick();
                if (Clock1.TimeTick % 4 == 0)
                {
                    Clock1.Alarm();
                }
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
