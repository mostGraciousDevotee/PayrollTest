class AddSalariedEmployee : AddEmployee
{
    double _salary;
    
    public AddSalariedEmployee
    (
        int employeeID,
        string employeeName,
        string address,
        double salary
    ) :
    base
    (
        employeeID,
        employeeName,
        address)
    {
        _salary = salary;
    }

    protected override Payment GetPayment()
    {
        return new SalariedPayment(_salary);
    }

    protected override PaymentSchedule GetSchedule()
    {
        return new MonthlySchedule();
    }
}