namespace ExpenseApprovalLib;

public interface IHandler
{
    IHandler SetNext(IHandler handler);
    object Handle(Expense expense);
}