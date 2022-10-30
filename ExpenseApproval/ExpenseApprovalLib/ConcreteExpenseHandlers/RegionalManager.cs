namespace ExpenseApprovalLib.ConcreteExpenseHandlers;

public class RegionalManager : ExpenseHandler
{
    private readonly double _approvalLimit = 10000;
    
    public override object Handle(Expense expense)
    {
        if(expense.Amount <= _approvalLimit)
        {
            return $"Expense approved by Regional Manager for {expense.Amount}";
        }
        else
        {
            return base.Handle(expense);
        }
    }
}