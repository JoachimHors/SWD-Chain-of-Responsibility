namespace ExpenseApprovalLib;

public abstract class ExpenseHandler : IHandler
{
    private IHandler _nextHandler;
    
    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual object Handle(Expense expense)
    {
        if (_nextHandler == null)
        {
            return "next handler not found";
        }
        return _nextHandler.Handle(expense);
        
    }
}