class AddTimeCardTest : EmployeeTest
{
    int _date = 20011031;
    double _hours = 8.0f;
    
    public AddTimeCardTest(int id, string name, string address) : base(id, name, address)
    {
    }

    public override bool Test()
    {
        var addHourlyEmployee = new AddHourlyEmployee
        (
            _id,
            _name,
            _address,
            250.0f
        );

        addHourlyEmployee.Execute();

        var addTimeCard = new AddTimeCard(_date, _hours, _id);
        addTimeCard.Execute();

        var employee = Database.GetEmployee(_id);
        if
        (
            !Assert.IsNotNull<Employee>
            (
                employee,
                "Failed to create employee!"
            )
        )
        {
            return false;
        }
        
        var hourlyPayment = employee!.Payment as HourlyPayment;
        bool paymentAdded = Assert.IsNotNull<HourlyPayment>
        (
            hourlyPayment,
            "Failed to get hourly payement!"
        );

        if (!paymentAdded) return false;

        var timeCard = hourlyPayment!.GetTimeCard(_date);
        bool timeCardAdded = Assert.IsNotNull<TimeCard>(timeCard, "Failed to get time card");

        if (!timeCardAdded) return false;
        bool hoursAdded = Assert.AreEqual<double>(_hours, timeCard.Hours, "Failed to get hours");

        return hoursAdded;
    }
}