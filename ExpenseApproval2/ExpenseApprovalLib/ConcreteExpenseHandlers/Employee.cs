namespace ExpenseApprovalLib.ConcreteExpenseHandlers;

public class Employee : ExpenseHandler
{
    private readonly double _approvalLimit;
    private readonly string _firstName;
    private readonly string _lastName;
    private readonly string _title;
    
    public Employee(string firstName, string lastName, string title, double approvalLimit)
    {
        _firstName = firstName;
        _lastName = lastName;
        _title = title;
        _approvalLimit = approvalLimit;
    }

    public override object Handle(Expense expense)
    {
        return expense.Amount <= _approvalLimit
            ? $"Expense: {expense.Description}\n" +
              $"Price: ${expense.Amount}\n" +
              $"Status: Approved by {_firstName} {_lastName}, {_title}\n" : base.Handle(expense);
        
        
    }
}