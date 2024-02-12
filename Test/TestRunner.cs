class TestRunner
{
    List<BaseTest> _tests = new List<BaseTest>();

    public void Run()
    {
        foreach (BaseTest test in _tests)
        {
            if (!test.Test())
            {
                return;
            }
        }

        Console.WriteLine("All test passed! Congratulation Faikar!");
    }

    public void AddTest(BaseTest test)
    {
        _tests.Add(test);
    }
}