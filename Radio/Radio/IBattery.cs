namespace Radio
{
    public interface IBattery
    {
        bool SelfCheck();
        int ChargeRemaining();
        string Manufactureer();
        string SerialNumber();
    }
}
