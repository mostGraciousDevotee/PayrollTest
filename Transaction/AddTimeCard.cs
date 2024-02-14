class AddTimeCard : ITransaction
{
    int _date;
    double _hours;
    int _employeeID;
    
    public AddTimeCard(int date, double hours, int employeeID)
    {
        _date = date;
        _hours = hours;
        _employeeID = employeeID;
    }
    
    public void Execute()
    {
        Employee? employee = Database.GetEmployee(_employeeID);

        if (employee != null)
        {
            var payment = employee.Payment as HourlyPayment;
            if (payment != null)
            {
                payment.AddTimeCard(_date, _hours);
            }
            else
            {
                throw new Exception("Tried to add timecard to non-hourly employee");
            }
        }
        else
        {
            throw new Exception("No such employee!");
        }
    }
}