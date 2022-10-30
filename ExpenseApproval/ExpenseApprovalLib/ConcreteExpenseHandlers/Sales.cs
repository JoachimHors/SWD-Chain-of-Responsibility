namespace ExpenseApprovalLib.ConcreteExpenseHandlers;

public class Sales : ExpenseHandler
{
    private readonly double _approvalLimit = 1000;
    
    public override object Handle(Expense expense)
    {
        if(expense.Amount <= _approvalLimit)
        {
            return $"Expense approved by Sales for {expense.Amount}";
        }
        else
        {
            return base.Handle(expense);
        }
    }
}