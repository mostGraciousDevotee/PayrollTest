class AddServiceChargeTest : EmployeeTest
{
    public AddServiceChargeTest
    (
        int id,
        string name,
        string address
    ) : base(id, name, address)
    {
    }

    public override bool Test()
    {
        var hourlyRate = 15.25f;
        var addHourlyEmployee = new AddHourlyEmployee(_id, _name, _address, hourlyRate);
        addHourlyEmployee.Execute();

        var employee = Database.GetEmployee(_id);
        bool employeeAdded = Assert.IsNotNull<Employee>(employee, "Failed to add employee");
        if (!employeeAdded)
        {
            return false;
        }

        var dues = 12.5f;
        var unionAffiliation = new UnionAffiliation(dues);
        employee!.Affiliation = unionAffiliation;
        var memberID = 86;
        Database.AddUnionMember(memberID, employee);

        var date = 20011101;
        var amount = 12.95f;
        var addServiceCharge = new AddServiceCharge(memberID, date, amount);
        addServiceCharge.Execute();

        var serviceCharge = unionAffiliation.GetServiceCharge(date);
        bool serviceChargeAdded = Assert.IsNotNull<ServiceCharge>(serviceCharge, "Failed to add service charge!");
        if (!serviceChargeAdded)
        {
            return false;
        }

        bool serviceAmountMathced = Assert.AreEqual(amount, serviceCharge.Amount, .001f, "Failed to add service amount");
        return serviceAmountMathced;
    }
}