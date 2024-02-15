var testRunner = new TestRunner();

testRunner.AddTest(new AddSalariedEmployeeTest
(
    1,
    "Wibisono",
    "Bandung"
));

testRunner.AddTest(new AddHourlyEmployeeTest
(
    2,
    "Irwan",
    "Surabaya"
));

testRunner.AddTest(new DeleteEmployeeTest
(
    3,
    "Eldy",
    "Bandung"
));

testRunner.AddTest(new AddTimeCardTest
(
    4,
    "Adri",
    "Medan"
));

testRunner.AddTest(new AddServiceChargeTest
(
    5,
    "Ony",
    "Surabaya"
));

testRunner.AddTest(new ChangeNameTest
(
    6,
    "Goyz",
    "Aty",
    "Bandung"
));

testRunner.Run();