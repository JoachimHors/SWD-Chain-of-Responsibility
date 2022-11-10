using ExpenseApprovalLib;
using ExpenseApprovalLib.ConcreteExpenseHandlers;

var jimHalpert = new Sales();
var dwightSchrute = new AssistantRegionalManager();
var michaelScott = new RegionalManager();
var janLevinson = new VicePresident();
var davidWallace = new CEO();


var expense = new Expense("A lot of paper", 1000);
var expense1 = new Expense("A lot of paper", 5000);
var expense2 = new Expense("A lot of paper", 5001);
var expense3 = new Expense("A lot of paper", 50000);
var expense4 = new Expense("A lot of paper", 100001);
var expense5 = new Expense("A lot of paper", 500001);
var client = new Client();

jimHalpert.SetNext(dwightSchrute);
dwightSchrute.SetNext(michaelScott);
michaelScott.SetNext(janLevinson);
janLevinson.SetNext(davidWallace);

client.SubmitExpense(jimHalpert, expense);
client.SubmitExpense(jimHalpert, expense1);
client.SubmitExpense(jimHalpert, expense2);
client.SubmitExpense(jimHalpert, expense3);
client.SubmitExpense(jimHalpert, expense4);
client.SubmitExpense(jimHalpert, expense5);
