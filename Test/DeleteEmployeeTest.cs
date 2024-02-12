class DeleteEmployeeTest : BaseTest
{
    public override bool Test()
    {
        bool deletedEmployee;
        
        int employeeID = 3;
        var addSalariedEmployee = new AddSalariedEmployee
        (
            employeeID,
            "Eldy",
            "Bandung",
            1000.0f
        );
        var deleteEmployee = new DeleteEmployee(employeeID);


        addSalariedEmployee.Execute();

        Employee? employee = Database.GetEmployee(employeeID);

        Assert.IsNotNull<Employee>
        (
            employee,
            "Failed to add employee"
        );

        if (employee == null)
        {
            return false;
        }

        deleteEmployee.Execute();

        employee = Database.GetEmployee(employeeID);

        deletedEmployee = Assert.IsNull<Employee>
        (
            employee,
            "failed to delete employee"
        );

        return deletedEmployee;
    }
}