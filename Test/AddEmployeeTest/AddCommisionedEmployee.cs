class AddCommisionedEmployeeTest : AddEmployeeTest
{
    double _salary = 500.0f;
    double _commisionRate = 250.0f;
    
    public AddCommisionedEmployeeTest
    (
        int id,
        string name,
        string address
    )
    : base(id, name, address)
    {
    }

    protected override void AddEmployee()
    {
        var addCommisionedEmployee = new AddCommisionedEmployee
        (
            _id,
            _name,
            _address,
            _salary,
            _commisionRate
        );

        addCommisionedEmployee.Execute();
    }

    protected override bool TestPayment(Employee employee)
    {
        return Assert.IsNotNull<Payment>
        (
            employee.Payment as CommisionedPayment,
            "Failed to add commisioned payment"
        );
    }

    protected override bool TestPaymentSchedule(Employee employee)
    {
        return Assert.IsNotNull<PaymentSchedule>
        (
            employee.PaymentSchedule as BiweeklySchecule,
            "Failed to add biweekly payment schedule!"
        );
    }
}