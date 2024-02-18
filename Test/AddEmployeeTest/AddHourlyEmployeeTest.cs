class AddHourlyEmployeeTest : AddEmployeeTest
{   
    double _hourlyRate = 250.0f;
    
    public AddHourlyEmployeeTest
    (
        int id,
        string name,
        string address
    )
    : base
    (
        id,
        name,
        address
    )
    {
    }

    protected override void AddEmployee()
    {
        var addHourlyEmployee = new AddHourlyEmployee
        (
            _id,
            _name,
            _address,
            _hourlyRate
        );

        addHourlyEmployee.Execute();
    }

    protected override bool TestPayment(Employee employee)
    {
        return Assert.IsNotNull<Payment>
        (
            employee.Payment as HourlyPayment,
            "Failed to add hourly payment"
        );
    }

    protected override bool TestPaymentSchedule(Employee employee)
    {
        return Assert.IsNotNull<PaymentSchedule>
        (
            employee.PaymentSchedule! as WeeklySchedule,
            "Failed to add weekly payment schedule"
        );
    }
}