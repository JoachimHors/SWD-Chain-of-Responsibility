namespace ExpenseApprovalLib;

public class Client
{
    public void SubmitExpense(ExpenseHandler handler, Expense expense)
    {
        var message = handler.Handle(expense);
        if (message != null)
        {
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("Expense not handled");
        }
    }
}