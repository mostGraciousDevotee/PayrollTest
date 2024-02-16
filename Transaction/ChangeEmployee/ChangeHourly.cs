class ChangeHourly : ChangeEmployee
{
    public ChangeHourly(int id) : base(id)
    {
    }

    protected override void Change(Employee employee)
    {
        throw new NotImplementedException();
    }
}