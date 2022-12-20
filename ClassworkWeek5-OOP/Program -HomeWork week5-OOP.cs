using System.Collections.Generic;
using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata;
using System.Transactions;
using System.Xml.Linq;
using Week5_OOP_Advanced;

//CLASSWORK
//Exercise 1
/*Create a class Author with one constructor to initialize the following Properties:
- Name
- Email
- Country
Add Print Method (to show all details)*/

/*Author mihaiEminescu = new Author
{
    Name = "Mihai Eminescu",
    Email = "asfasa@asfew.com",
    Country = "Romania"
};*/

//Exercise 2

/*Create a BankAccount class that has the following private properties: 
-AccountNumber
- AccountHolder
- Balance
- Transactions.

The transactions property should be a list of strings that represent the history of transactions for the bank account.
The BankAccount class should have the following public methods:
-Deposit(amount): adds the specified amount to the account balance and adds a string to the transactions list in the following format: "Deposited $[amount]".
- Withdraw(amount): subtracts the specified amount from the account balance and adds a string to the transactions list in the following format: "Withdrew $[amount]".
- GetBalance(): returns the current balance of the account.
- GetTransactionHistory(): returns a list of strings representing the transaction history for the account.

The BankAccount class should also have the following public properties that allow the accountNumber and accountHolder properties to be accessed and modified:

AccountNumber: gets or sets the accountNumber property.
AccountHolder: gets or sets the accountHolder property.*/

/*BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);

myAccount.Deposit(500);
myAccount.Withdraw(200);

Console.WriteLine(myAccount.GetBalance()); // Outputs 1300

List<string> transactions = myAccount.GetTransactionHistory();
foreach (string transaction in transactions)
{
    Console.WriteLine(transaction);
}

*//* Outputs:
Deposited $500
Withdrew $200
*//*

myAccount.AccountNumber = 654321;
myAccount.AccountHolder = "Jane Smith";

Console.WriteLine(myAccount.AccountNumber); // Outputs 654321
Console.WriteLine(myAccount.AccountHolder); // Outputs "Jane Smith"*/


//Exercise 3

/*Teacher firstTeacher = new Teacher
{
    FirstName = "Mihai",
    LastName = "Popescu",
    Age = 42,
    Gender = "FEMale"
};

firstTeacher.Introduce();*/


//Exercise 4

/*Create an abstract Shape class that has the following abstract methods:
-GetArea(): returns the area of the shape.
- GetPerimeter(): returns the perimeter of the shape.

Next, create a Circle class that inherits from the Shape class and has the following private properties: radius and PI. 
The Circle class should override the GetArea() and GetPerimeter() methods from the Shape class and implement 
   them using the formula for the area and perimeter of a circle.

Finally, create a Rectangle class that inherits from the Shape class and has the following private properties: width and height.
The Rectangle class should override the GetArea() and GetPerimeter() methods from the Shape class 
    and implement them using the formula for the area and perimeter of a rectangle.*/

/*Circle myCircle = new Circle(5);
Week5_OOP_Advanced.Rectangle myRectangle = new Week5_OOP_Advanced.Rectangle(5, 10);

Console.WriteLine(myCircle.GetArea()); // Outputs 78.5398163397448
Console.WriteLine(myCircle.GetPerimeter()); // Outputs 31.4159265358979

Console.WriteLine(myRectangle.GetArea()); // Outputs 50
Console.WriteLine(myRectangle.GetPerimeter()); // Outputs 30*/




//Exercise 5

/*Create an abstract Employee class that has the following properties: 
-FirstName
- LastName
- Salary.

The Employee class should have the following methods:

-GetFullName(): returns the employee's full name (i.e. first name followed by last name).
- GetMonthlySalary(): returns the employee's monthly salary (i.e. salary divided by 12).

Next, create a sealed Manager class that inherits from the Employee class and has the following property: 
-Employee(a list of Employee objects that represent the employees that the manager oversees)

The Manager class should have the following methods:

-AddEmployee(employee): adds the specified Employee object to the employees list.
- GetTotalMonthlySalary(): returns the total monthly salary of all the employees that the manager oversees 
    (i.e. the sum of the monthly salaries of all the employees in the employees list).

Finally, create a RegularEmployee class that inherits from the Employee class. 
    The RegularEmployee class should be sealed, meaning that it cannot be inherited from.*/


Manager john = new Manager("John", "Doe", 50000);
RegularEmployee jane = new RegularEmployee("Jane", "Smith", 30000);

john.AddEmployee(jane);

Console.WriteLine(john.GetFullName()); // Outputs "John Doe"
Console.WriteLine(jane.GetFullName()); // Outputs "Jane Smith"

Console.WriteLine(john.GetMonthlySalary()); // Outputs 4166.66666666667
Console.WriteLine(jane.GetMonthlySalary()); // Outputs 2500

Console.WriteLine(john.GetTotalMonthlySalary()); // Outputs 6666.66666666667