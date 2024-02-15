class ChangeName : ChangeEmployee
{
    string _newName;
    
    public ChangeName(int id, string newName) : base(id)
    {
        _newName = newName;
    }

    protected override void Change(Employee employee)
    {
        employee.Name = _newName;
    }
}