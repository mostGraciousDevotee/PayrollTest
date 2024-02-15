class AddHourlyEmployeeTest : EmployeeTest
{   
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

    public override bool Test()
    {
        bool nameAdded;
        bool paymentAdded;
        bool scheduleAdded;
        bool methodAdded;
        
        int employeeID = 2;
        var addHourlyEmployee = new AddHourlyEmployee
        (
            _id,
            _name,
            _address,
            250.0f
        );

        addHourlyEmployee.Execute();

        Employee? employee = Database.GetEmployee(employeeID);

        Assert.IsNotNull<Employee>
        (
            employee,
            "Failed to get employee"
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
            employee.PaymentSchedule! as WeeklySchedule,
            "Failed to add employee payment schedule"
        );

        paymentAdded = Assert.IsNotNull<Payment>
        (
            employee.Payment as HourlyPayment,
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