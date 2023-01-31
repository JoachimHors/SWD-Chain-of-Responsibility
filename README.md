# SWD-Chain-of-Responsibility
Mandatory Assignment in the course Sofware Design



## Design
Class diagram of the general structure of a program implementing the chain of responsibility pattern. Example from [Refactoring Guru](https://refactoring.guru/design-patterns/chain-of-responsibility)

```mermaid
classDiagram
    IHandler <|.. BaseHandler
    BaseHandler --> IHandler
    BaseHandler <|-- ConcreteHandler
    IHandler <-- Client

    <<interface>>IHandler
    class IHandler{
        +setNext(IHandler)
        +handle(request)
    }
    

    class BaseHandler{
        -next: IHandler

        +setNext(IHandler)
        +handle(request)
    }

    class ConcreteHandler{
        ...

        + handle(request)
    }
```

This repository includes an example of how the chain of responsibility pattern can be used to automate the process of approving or declining submitted expenses. 

The behavior we want will ensure that employees will only send the decision of approval over to their boss, if they are not authorized to do it themselves.

The following sequence diagram will illustrate this.

```mermaid
sequenceDiagram
    Actor Client
    Client->>Sales: Expense

    alt is less than or equal to $1000
        Sales->>Client: Approved
    else is above $1000
        Sales->>Assistant Regional Manager: Expense
    end


    alt is less than or equal to $5000
        Assistant Regional Manager->>Client: Approved
    else is above $5000
        Assistant Regional Manager->> Regional Manager: Expense
    end

    alt is less than or equal to $10000
        Regional Manager->>Client: Approved
    else is above $10000
        Regional Manager->> Vice President: Expense
    end
    
    alt is less than or equal to $100000
        Vice President->>Client: Approved
    else is above $100000
        Vice President->> CEO: Expense
    end

    alt is less than or equal to $500000
        CEO->>Client: Approved
    else is above $500000
        CEO->> Client: Declined
    end
```

Class diagram of the example
```mermaid
classDiagram
    IHandler <|.. ExpenseHandler
    ExpenseHandler --> IHandler
    IHandler --> Expense
    ExpenseHandler <|-- Sales
    ExpenseHandler <|-- AssistantRegionalManager
    ExpenseHandler <|-- RegionalManager
    ExpenseHandler <|-- VicePresident
    ExpenseHandler <|-- CEO

    <<interface>>IHandler
    class IHandler{
        +setNext(IHandler)
        +handle(Expense)
    }

    class ExpenseHandler{
        -next: IHandler

        +setNext(IHandler)
        +handle(expense)
    }

    class Sales{
        - approvalLimit: double

        + handle(request)
    }
    class AssistantRegionalManager{
        - approvalLimit: double

        + handle(request)
    }
    class RegionalManager{
        - approvalLimit: double

        + handle(request)
    }
    class VicePresident{
        - approvalLimit: double

        + handle(request)
    }
    class CEO{
        - approvalLimit: double

        + handle(request)
    }
```

As all the Concrete handlers function as employees approving expenses based on price, they can all be instances of an Employee class instead


```mermaid
classDiagram
    IHandler --> Expense
    IHandler <|.. ExpenseHandler
    ExpenseHandler --> IHandler
    ExpenseHandler <|-- Employee
    
    <<interface>>IHandler
    class IHandler{
        +setNext(IHandler)
        +handle(Expense)
    }

    class ExpenseHandler{
        -next: IHandler

        +setNext(IHandler)
        +handle(expense)
    }

    class Employee{
        - approvalLimit: double
        - title
        - firstName: string
        - lastName: string

        + handle(request)
    }
```

With this design, we're still using the Chain of responsibility pattern, as the Employee objects can send the expense to other expensehandler object.



## Links
[Mermaid Documentation](https://mermaid-js.github.io/mermaid/#/)

[Refactoring Guru](https://refactoring.guru/design-patterns/chain-of-responsibility)
