namespace Calendar
{
    public class LeapYear
    {
        public bool IsLeapYear(int Year)
        {
            if (Year % 100 == 0)
            {
                return false;
            }
            else
            {
            return Year % 4 == 0;
            }
        }
    }
}