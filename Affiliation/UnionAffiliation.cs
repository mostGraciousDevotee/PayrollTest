class UnionAffiliation : Affiliation
{
    double _dues;
    Dictionary<int, ServiceCharge> _serviceCharges = new Dictionary<int, ServiceCharge>();

    public UnionAffiliation(double dues)
    {
        _dues = dues;
    }

    public void AddServiceCharge(int date, double amount)
    {
        var serviceCharge = new ServiceCharge(amount);
        _serviceCharges.Add(date, serviceCharge);
    }

    public ServiceCharge GetServiceCharge(int date)
    {
        return _serviceCharges[date];
    }
}