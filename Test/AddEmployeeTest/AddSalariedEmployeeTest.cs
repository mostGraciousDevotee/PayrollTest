class AddSalariedEmployeeTest : AddEmployeeTest
{
    double _salary = 1000.0f;
    
    public AddSalariedEmployeeTest
    (
        int id,
        string name,
        string address
    ) : base 
    (
        id,
        name,
        address
    ) {}

    protected override void AddEmployee()
    {
        var addSalariedEmployee = new AddSalariedEmployee
        (
            _id,
            _name,
            _address,
            _salary
        );

        addSalariedEmployee.Execute();
    }

    protected override bool TestPayment(Employee employee)
    {
        return Assert.IsNotNull<Payment>
        (
            employee.Payment as SalariedPayment,
            "Failed to add salaried payment"
        );
    }

    protected override bool TestPaymentSchedule(Employee employee)
    {
        return Assert.IsNotNull<PaymentSchedule>
        (
            employee.PaymentSchedule! as MonthlySchedule,
            "Failed to add monthly payment schedule"
        );
    }
}