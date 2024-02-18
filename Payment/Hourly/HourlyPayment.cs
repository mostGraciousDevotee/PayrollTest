class HourlyPayment : Payment
{
    double _rate;
    Dictionary<int, TimeCard> _timeCards = new Dictionary<int, TimeCard>();

    public HourlyPayment(double rate)
    {
        _rate = rate;
    }

    public void AddTimeCard(TimeCard timeCard)
    {
        _timeCards.Add(timeCard.Date, timeCard);
    }
    
    public TimeCard GetTimeCard(int date)
    {
        return _timeCards[date];
    }
}