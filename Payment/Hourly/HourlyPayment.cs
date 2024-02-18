class HourlyPayment : Payment
{
    double _rate;
    Dictionary<int, TimeCard> _timeCards = new Dictionary<int, TimeCard>();

    public HourlyPayment(double rate)
    {
        _rate = rate;
    }

    public void AddTimeCard(int date, double hours)
    {
        var timeCard = new TimeCard(date, hours);
        _timeCards.Add(date, timeCard);
    }
    
    public TimeCard GetTimeCard(int date)
    {
        return _timeCards[date];
    }
}