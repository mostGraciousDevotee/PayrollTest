class AddSalesReceiptTest : EmployeeTest
{
    int _date = 20011031;
    double _amount = 250.0f;
    double _salary = 500.0f;
    double _commisionRate = 0.05f;

    public AddSalesReceiptTest(int id, string name, string address) : base(id, name, address)
    {
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

        var addSalesReceipt = new AddSalesReceipt(_date, _amount, _id);
        addSalesReceipt.Execute();

        var employee = Database.GetEmployee(_id);
        if
        (
            !Assert.IsNotNull<Employee>
            (
                employee,
                "Failed to create employee"
            )
        )
        {
            return false;
        }

        var commisionedPayment = employee!.Payment as CommisionedPayment;
        bool paymentAdded = Assert.IsNotNull<CommisionedPayment>
        (
            commisionedPayment,
            "Failed to get commisioned payment!"
        );

        if (paymentAdded == false) return false;

        var salesReceipt = commisionedPayment!.GetSalesReceipt(_date);
        bool salesReceiptAdded = Assert.IsNotNull<SalesReceipt>(salesReceipt, "Failed to get sales receipt");

        return salesReceiptAdded;
    }
}