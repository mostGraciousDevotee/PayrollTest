class CommisionedPayment : Payment
{
    double _salary;
    double _commisionRate;

    public CommisionedPayment(double salary, double commisionRate)
    {
        _salary = salary;
        _commisionRate = commisionRate;
    }
}