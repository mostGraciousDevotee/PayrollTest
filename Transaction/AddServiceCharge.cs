class AddServiceCharge : ITransaction
{
    int _memberID;
    int _date;
    double _amount;

    public AddServiceCharge(int memberID, int date, double amount)
    {
        _memberID = memberID;
        _date = date;
        _amount = amount;
    }

    public void Execute()
    {
        var employee = Database.GetUnionMember(_memberID);
        var affiliation = employee?.Affiliation as UnionAffiliation;
        if ( affiliation != null)
        {
            affiliation.AddServiceCharge(_date, _amount);
        }
    }
}