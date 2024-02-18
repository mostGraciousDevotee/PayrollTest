class SalesReceipt
{
    int _date;
    double _amount;

    public SalesReceipt(int date, double amount)
    {
        _date = date;
        _amount = amount;
    }

    public int Date => _date;
    public double Amount => _amount;
}