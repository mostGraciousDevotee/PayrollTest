static class Database
{
    static Dictionary<int, Employee> _employeeDictionary = new Dictionary<int, Employee>();
    static Dictionary<int, Employee> _unionDictionary = new Dictionary<int, Employee>();
    
    public static void AddEmployee(Employee employee)
    {
        _employeeDictionary.Add(employee.ID, employee);
    }

    public static void DeleteEmployee(int id)
    {
        _employeeDictionary.Remove(id);
    }
    
    public static Employee? GetEmployee(int id)
    {
        if (_employeeDictionary.TryGetValue(id, out Employee? employee))
        {
            return employee;
        }
        else
        {
            return null;
        }
    }

    public static void AddUnionMember(int memberID, Employee employee)
    {
        _unionDictionary.Add(memberID, employee);
    }
    public static Employee? GetUnionMember(int memberID)
    {
        return _unionDictionary[memberID];
    }
}