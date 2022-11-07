namespace ExpenseApprovalLib;

public abstract class ExpenseHandler : IHandler
{
    private IHandler _nextHandler = null!;
    
    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual object Handle(Expense expense)
    {
        if (_nextHandler == null)
        {
            return $"Expense: {expense.Description}\n" +                      
                   $"Price: ${expense.Amount}\n" +                            
                   $"Status: Declined\n";
        }
        return _nextHandler.Handle(expense);
        
    }
}