class Employee
{
    int _id;
    string _name;
    string _address;

    Payment? _payment;
    PaymentSchedule? _paymentSchedule;
    PaymentMethod? _paymentMethod;
    Affiliation? _affiliation;
    
    public Employee(int id, string name, string address)
    {
        _id = id;
        _name = name;
        _address = address;
    }

    public int ID => _id;

    public string Name
    {
        get => _name;
        set => _name = value;
    }
    
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

    public Affiliation? Affiliation
    {
        get => _affiliation;
        set => _affiliation = value;
    }
}