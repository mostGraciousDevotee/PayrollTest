class DeleteEmployee : ITransaction
{
    int _id;

    public DeleteEmployee(int id)
    {
        _id = id;
    }
    
    public void Execute()
    {
        Database.DeleteEmployee(_id);
    }
}