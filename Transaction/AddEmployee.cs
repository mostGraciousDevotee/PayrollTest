abstract class AddEmployee : ITransaction
{
    int _id;
    string _name;
    string _address;

    public AddEmployee(int id, string name, string address)
    {
        _id = id;
        _name = name;
        _address = address;
    }
    
    public virtual void Execute()
    {
        Employee employee = new Employee(_id, _name, _address);
        
        employee.Payment = GetPayment();
        employee.PaymentSchedule = GetSchedule();
        employee.PaymentMethod = new HoldMethod();

        Database.AddEmployee(employee);
    }

    protected abstract Payment GetPayment();
    protected abstract PaymentSchedule GetSchedule();
}