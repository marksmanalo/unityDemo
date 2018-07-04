namespace Radio
{
    public class Battery : IBattery
    {
        public bool SelfCheck()
        {
            return true;
        }

        public int ChargeRemaining()
        {
            return 70;
        }

        public string Manufactureer()
        {
            return "Duracell";
        }

        public string SerialNumber()
        {
            return "123XDRFE34";
        }
    }
}
