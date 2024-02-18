class CommisionedPayment : Payment
{
    double _salary;
    double _commisionRate;
    Dictionary<int, SalesReceipt> _salesReceipts = new Dictionary<int, SalesReceipt>();

    public CommisionedPayment(double salary, double commisionRate)
    {
        _salary = salary;
        _commisionRate = commisionRate;
    }

    // public void AddSalesReceipt(int date, )
}