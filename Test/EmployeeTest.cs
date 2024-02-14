abstract class EmployeeTest : BaseTest
{
    protected int _id;
    protected string _name;
    protected string _address;

    public EmployeeTest(int id, string name, string address)
    {
        _id = id;
        _name = name;
        _address = address;
    }
}