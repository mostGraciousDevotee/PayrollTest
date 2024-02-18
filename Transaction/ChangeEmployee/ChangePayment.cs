abstract class ChangePayment : ChangeEmployee
{
    protected ChangePayment(int id) : base(id)
    {
    }

    protected abstract Payment Payment {get; }
    protected abstract PaymentSchedule PaymentSchedule {get; }
    protected override void Change(Employee employee)
    {
        employee.Payment = Payment;
        employee.PaymentSchedule = PaymentSchedule;
    }
}