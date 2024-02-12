var testRunner = new TestRunner();

testRunner.AddTest(new AddSalariedEmployeeTest());
testRunner.AddTest(new DeleteEmployeeTest());

testRunner.Run();