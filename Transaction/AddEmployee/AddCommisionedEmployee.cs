class AddCommisionedEmployee : AddEmployee
{
    double _salary;
    double _commisionRate;
    
    public AddCommisionedEmployee
    (
        int id,
        string name,
        string address,
        double salary,
        double commisionRate
    ) : base(id, name, address)
    {
        _salary = salary;
        _commisionRate = commisionRate;
    }

    protected override Payment GetPayment()
    {
        return new CommisionedPayment(_salary, _commisionRate);
    }

    protected override PaymentSchedule GetSchedule()
    {
        return new BiweeklySchecule();
    }
}