namespace Calendar
{
    public class LeapYear
    {
        public bool IsLeapYear(int Year)
        {
            return Year % 4 == 0;
        }
    }
}