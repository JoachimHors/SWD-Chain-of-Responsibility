using ExpenseApprovalLib;
using ExpenseApprovalLib.ConcreteExpenseHandlers;

var jimHalpert = new Sales();
var dwightSchrute = new AssistantRegionalManager();
var michaelScott = new RegionalManager();
var janLevinson = new VicePresident();
var davidWallace = new CEO();

var expense = new Expense("A lot of paper", 1000);
var client = new Client();

jimHalpert.SetNext(dwightSchrute);
dwightSchrute.SetNext(michaelScott);
michaelScott.SetNext(janLevinson);
janLevinson.SetNext(davidWallace);

client.SubmitExpense(jimHalpert, expense);

