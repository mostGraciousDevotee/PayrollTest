abstract class AddEmployeeTest : EmployeeTest
{
    protected AddEmployeeTest
    (
        int id,
        string name,
        string address
    ) : base(id, name, address)
    {
    }

    public override bool Test()
    {
        bool nameAdded = false;
        bool paymentAdded = false;
        bool scheduleAdded = false;
        bool methodAdded = false;

        AddEmployee();

        var employee = Database.GetEmployee(_id);

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

        paymentAdded = TestPayment();
        scheduleAdded = TestPaymentSchedule();
        methodAdded = TestPaymentMethod();

        return
            nameAdded &&
            paymentAdded &&
            scheduleAdded &&
            methodAdded;
    }

    abstract protected void AddEmployee();
    abstract protected bool TestPayment();
    abstract protected bool TestPaymentSchedule();
    abstract protected bool TestPaymentMethod();
}