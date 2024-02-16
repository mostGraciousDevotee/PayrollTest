class ChangeNameTest : EmployeeTest
{
    string _newName;
    public ChangeNameTest
    (
        int id,
        string name,
        string newName,
        string address
    ) : base(id, name, address)
    {
        _newName = newName;
    }

    public override bool Test()
    {
        var addHourlyEmployee = new AddHourlyEmployee(_id, _name, _address, 15.25);
        addHourlyEmployee.Execute();

        var changeName = new ChangeName(_id, _newName);
        changeName.Execute();

        var employee = Database.GetEmployee(_id);

        bool nameChanged = Assert.AreEqual<string>
        (
            _newName,
            employee!.Name,
            "Failed to change employee name!"
        );

        return nameChanged;
    }
}