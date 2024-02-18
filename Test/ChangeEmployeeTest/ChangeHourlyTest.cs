class ChangeHourlyTest : EmployeeTest
{
    double _salary;
    double _commisionRate;
    double _hourlyRate;
    
    public ChangeHourlyTest
    (
        int id,
        string name,
        string address
    ) : base(id, name, address)
    {
        _salary = 1000.0f;
        _commisionRate = 0.1f;
        _hourlyRate = 25.2f;
    }

    public override bool Test()
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

        var changeHourly = new ChangeHourly(_id, _hourlyRate);
        changeHourly.Execute();

        var employee = Database.GetEmployee(_id);
        var employeeFetched = Assert.IsNotNull<Employee>
        (
            employee,
            "Failed to fetch employee"
        );

        if (employee == null)
        {
            return false;
        }

        var payment = employee.Payment;
        var paymentFetched = Assert.IsNotNull<Payment>
        (
            payment,
            "Failed to fetch payment"
        );

        if (payment == null)
        {
            return false;
        }

        var hourlyPayment = payment as HourlyPayment;
        var hourlyPaymentFetched = Assert.IsNotNull<HourlyPayment>
        (
            hourlyPayment,
            "Failed to fetch hourlyPayment"
        );
        
        if (hourlyPayment == null)
        {
            return false;
        }

        var schedule = employee.PaymentSchedule as WeeklySchedule;
        var scheduleChanged = Assert.IsNotNull<WeeklySchedule>
        (
            schedule,
            "Failed to change payment schedule"
        );

        if (schedule == null)
        {
            return false;
        }

        var correctHourlyRate = Assert.AreEqual
        (
            _hourlyRate,
            hourlyPayment.Rate,
            "Incorrect hourly rate"
        );

        return correctHourlyRate;
    }
}