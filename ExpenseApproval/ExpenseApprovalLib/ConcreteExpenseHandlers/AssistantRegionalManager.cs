namespace ExpenseApprovalLib.ConcreteExpenseHandlers;

public class AssistantRegionalManager : ExpenseHandler
{
    private readonly double _approvalLimit = 5000;
    
    public override object Handle(Expense expense)
    {
        if(expense.Amount <= _approvalLimit)
        {
            return $"Expense approved by Assistant Regional Manager for {expense.Amount}";
        }
        else
        {
            return base.Handle(expense);
        }
    }
}