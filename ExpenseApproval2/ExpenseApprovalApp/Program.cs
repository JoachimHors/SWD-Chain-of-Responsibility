using ExpenseApprovalLib;
using ExpenseApprovalLib.ConcreteExpenseHandlers;

var employee1 = new Employee("Jim", "Halpert","Sales", 1000);
var employee2 = new Employee("Dwight", "Schrute","Assistant to the Regional Manager", 5000);
var employee3 = new Employee("Michael", "Scott","Regional Manager", 10000);
var employee4 = new Employee("Jan", "Levinson","Vice President", 50000);
var employee5 = new Employee("David", "Wallace","CEO", 100000);

var expense = new Expense("A lot of paper", 300);
var expense2 = new Expense("A lot of paper", 5000);
var expense3 = new Expense("A lot of paper", 5001);
var expense4 = new Expense("A lot of paper", 50000);
var expense5 = new Expense("A lot of paper", 100000);
var expense6 = new Expense("A lot of paper", 100001);

var client = new Client();

employee1.SetNext(employee2);
employee2.SetNext(employee3);
employee3.SetNext(employee4);
employee4.SetNext(employee5);

client.SubmitExpense(employee1, expense);
client.SubmitExpense(employee1, expense2);
client.SubmitExpense(employee1, expense3);
client.SubmitExpense(employee1, expense4);
client.SubmitExpense(employee1, expense5);
client.SubmitExpense(employee1, expense6);

