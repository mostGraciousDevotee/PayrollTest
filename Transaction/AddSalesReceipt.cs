class AddSalesReceipt : ITransaction
{
    int _date;
    double _amount;    
    int _employeeID;

    public AddSalesReceipt(int date, double amount, int employeeID)
    {
        _date = date;
        _amount = amount;
        _employeeID = employeeID;
    }

    public void Execute()
    {
        Employee? employee = Database.GetEmployee(_employeeID);

        if (employee != null)
        {
            var payment = employee.Payment as CommisionedPayment;
            if (payment != null)
            {

            }
            else
            {
                throw new Exception("Tried to add salesReceipt to non-commisioned employee!");
            }
        }
        else
        {
            throw new Exception("No such employee!");
        }
    }
}