namespace Radio
{
    public class Tuner : ITuner
    {
        public string Manufacturer()
        {
            return "Radioshack";
        }

        public int TunedFrequency()
        {
            return (int) 92.3;
        }

        public bool SelfCheck()
        {
            return true;
        }

        public string SerialNumber()
        {
            return "123FWR341";
        }
    }
}
