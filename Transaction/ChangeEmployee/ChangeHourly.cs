class ChangeHourly : ChangePayment
{
    double _hourlyRate;
    
    public ChangeHourly(int id, double hourlyRate) : base(id)
    {
        _hourlyRate = hourlyRate;
    }

    protected override Payment Payment => new HourlyPayment(_hourlyRate);

    protected override PaymentSchedule PaymentSchedule => new WeeklySchedule();
}