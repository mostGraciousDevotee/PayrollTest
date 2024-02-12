class AddSalariedEmployeeTest : BaseTest
{
    public override bool Test()
    {
        bool nameAdded;
        bool paymentAdded;
        bool scheduleAdded;
        bool methodAdded;
        
        int employeeID = 1;
        var addSalariedEmployee = new AddSalariedEmployee
        (
            employeeID,
            "Wibisono",
            "Bandung",
            1000.0f
        );

        addSalariedEmployee.Execute();

        Employee? employee = Database.GetEmployee(employeeID);

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
            "Wibisono",
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
            scheduleAdded;
    }
}