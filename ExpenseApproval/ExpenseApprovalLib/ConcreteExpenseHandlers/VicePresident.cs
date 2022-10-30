namespace ExpenseApprovalLib.ConcreteExpenseHandlers;

public class VicePresident : ExpenseHandler
{
    private readonly double _approvalLimit = 100000;
    
    public override object Handle(Expense expense)
    {
        if(expense.Amount <= _approvalLimit)
        {
            return $"Expense approved by Vice President for {expense.Amount}";
        }
        else
        {
            return base.Handle(expense);
        }
    }
}