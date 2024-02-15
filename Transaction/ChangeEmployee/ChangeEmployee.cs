abstract class ChangeEmployee : ITransaction
{
    int _id;

    protected ChangeEmployee(int id)
    {
        _id = id;
    }

    public void Execute()
    {
        var employee = Database.GetEmployee(_id);
        if (employee != null)
        {
            Change(employee);
        }
    }

    protected abstract void Change(Employee employee);
}