class AddHourlyEmployee : AddEmployee
{
    double _rate;

    public AddHourlyEmployee
    (
        int id,
        string name,
        string address,
        double rate
    ) :
    base
    (
        id,
        name,
        address
    )
    {
        _rate = rate;
    }

    protected override Payment GetPayment()
    {
        return new HourlyPayment(_rate);
    }

    protected override PaymentSchedule GetSchedule()
    {
        return new WeeklySchedule();
    }
}