class Employee
{
    int _id;
    string _name;
    string _address;

    Payment? _payment;
    PaymentSchedule? _paymentSchedule;
    PaymentMethod? _paymentMethod;
    
    public Employee(int id, string name, string address)
    {
        _id = id;
        _name = name;
        _address = address;
    }

    public int ID => _id;
    public string Name => _name;

    public Payment? Payment
    {
        get => _payment;
        set => _payment = value;
    }
    public PaymentSchedule? PaymentSchedule
    {
        get => _paymentSchedule;
        set => _paymentSchedule = value;
    }

    public PaymentMethod? PaymentMethod
    {
        get => _paymentMethod;
        set => _paymentMethod = value;
    }
    
}