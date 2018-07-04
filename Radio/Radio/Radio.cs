using System;

namespace Radio
{
    public class Radio : IRadio
    {
        public IBattery Battery { get; set; }
        public string Name { get; set; }
        public ITuner Tuner { get; set; }
        public string RadioName()
        {
            return Name;
        }

        public void Start()
        {
            Console.WriteLine(Name + " radio started...");
        }
    }
}
