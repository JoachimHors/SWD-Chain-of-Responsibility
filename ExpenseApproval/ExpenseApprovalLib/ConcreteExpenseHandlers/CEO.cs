namespace ExpenseApprovalLib.ConcreteExpenseHandlers;

public class CEO : ExpenseHandler

{
    private double _approvalLimit = 500000;
    
    public override object Handle(Expense expense)
    {
        if(expense.Amount <= _approvalLimit)
        {
            return $"Expense approved by CEO for {expense.Amount}";
        }
        else
        {
            return $"Expense rejected by CEO";
        }
    }
}