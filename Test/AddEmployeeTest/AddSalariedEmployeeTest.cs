class AddSalariedEmployeeTest : EmployeeTest
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
    
    public override bool Test()
    {
        bool nameAdded;
        bool paymentAdded;
        bool scheduleAdded;
        bool methodAdded;
        
        var addSalariedEmployee = new AddSalariedEmployee
        (
            _id,
            _name,
            _address,
            _salary
        );

        addSalariedEmployee.Execute();

        Employee? employee = Database.GetEmployee(_id);

        Assert.IsNotNull<Employee>
        (
            employee,
            "Failed to add employee!"
        );

        if (employee == null)
        {
            return false;
        }
        
        nameAdded = Assert.AreEqual<string>
        (
            _name,
            employee.Name,
            "Failed to add employee name"
        );

        scheduleAdded = Assert.IsNotNull<PaymentSchedule>
        (
            employee.PaymentSchedule! as MonthlySchedule,
            "Failed to add employee payment schedule"
        );

        paymentAdded = Assert.IsNotNull<Payment>
        (
            employee.Payment as SalariedPayment,
            "Failed to add salaried payment"
        );

        methodAdded = Assert.IsNotNull<PaymentMethod>
        (
            employee.PaymentMethod as HoldMethod,
            "Failed to add hold method!"
        );

        return
            nameAdded &&
            paymentAdded &&
            scheduleAdded &&
            methodAdded;
    }
}