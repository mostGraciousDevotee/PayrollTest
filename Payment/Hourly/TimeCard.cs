class TimeCard
{
    int _date;
    double _hours;

    public TimeCard(int date, double hours)
    {
        _date = date;
        _hours = hours;
    }

    public int Date => _date;
    public double Hours => _hours;
}