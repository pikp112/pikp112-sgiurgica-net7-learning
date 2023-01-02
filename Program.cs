using System;
using Week5_OOP_Advanced;
//using Week5_OOP_Advanced.Week5_day1;
//using Week5_OOP_Advanced.Week5_day2;
//using Week5_OOP_Advanced.HomeworkWeek5_OOP_Advanced.Ex_3;



/*string[] coursesForAlex = new string[3] { "Math", "English", "Example" };
Student alex = new Student(coursesForAlex);

alex.PrintCourses();

List<string> flaviaCourses=new List<string>() { "Math", "Ex","Ex2"};
Student flavia = new Student(flaviaCourses);

flavia.PrintCourses2();
*/
/*
                                    //ENCAPSULATION
Teacher teacher = new Teacher();        //public
teacher.name = "Alex";                  //public

teacher.SetSalary(2000);                //private     



Account alexAccount = new Account();
/*alexAccount.balance = 100_000;
alexAccount = 90_000;
alexAccount -= 110_000;*/
/*alexAccount.AddBalance(10_000);
Console.WriteLine(alexAccount.Balance); //inainte era cu GetBalance() - este proprietatea GET ce returneaza balance
alexAccount.Balance = 20_000;           //se activeaza PROPRIETATEA SET iar value=20000
alexAccount.AddBalance(-10_000);        

Teacher teacher = new Teacher();
teacher.Name = "Alex";
teacher.Email = "asfa@gmail.com";
teacher.SetSalary(199);*/

/*Account alexAccount = new Account()
{
    Balance = 10_000    //CTRL+SPACE (shortcut)
};

//EQUAL

Account alexAccount = new Account()
alexAccount.Balance=10_000;


List<string> myList = new List<string>(){ "Example", "Example2", "Example3" };*/

//1.Exercise class Author

/*Author mihaiEminescu=new Author();                POTI adauga valori prin FIELD sau prin PROPERTIES
mihaiEminescu.name = "Mihai Eminescu";              Aici adaugi valori prin FIELD-uri
mihaiEminescu.email = "afsa@masf.com";
mihaiEminescu.country = "RO";
mihaiEminescu.id = -10;*/

//SAU
/*Author mihaiEminescu = new Author()                 de forma Collection Initializer
{
    Name = "Mihai EMinescu",                        
    Email = "eacsa@asafa.com",                      Adaugi valori prin PROPRIETATI
    Country = "Romania",
    Id = 12312
    
};

mihaiEminescu.Print();*/

/*Author alexAuthor=new Author("Alex");
Console.WriteLine(alexAuthor.Name);    //se executa codul GET din proprietatea Name

//OR

Author alexAuthor2 = new Author();
alexAuthor2.SetName("Alex2");
Console.WriteLine(alexAuthor2.Name);

//OR

Author alexAuthor3 = new Author();
alexAuthor3.Name="Alex3";
Console.WriteLine(alexAuthor3.Name);*/

//Vehicle newCar=new Vehicle();                 Este ABSTRACTA => NU SE POATE

/*AudiVehicle audi = new AudiVehicle              //mosteneste proprietati de la Vehicle
{
    Color = "White",
    Name = "A3",
    NumberOfWheels = 5
};
audi.Start();

FordVehicle ford=new FordVehicle();
ford.Start();*/


//Week5 - day 2



/*Person firstPerson = new Person                 //NU POTI pentru ca e o clasa ABSTRACTA
{
    FirstName = "Mihai",
    LastName = "Popescu",
    Age = 42,
    Gender = "FEMale"
};*/


/*Teacher2 firstTeacher = new Teacher2
{
    FirstName = "Mihai",
    LastName = "Popescu",
    Age = 42,
    Gender = "FEMale"
};

firstTeacher.Introduce();*/

//STATIC POLIMORFISM sau METHOD OVERLOAD

/*Console.WriteLine(new Calculator().Add(1,3));       //metoda cu int
Console.WriteLine(new Calculator().Add(1.5,6.4));   //metoda cu double

        //DYNAMIC POLIFORFISM sau METHOD OVERRIDE

//Animal dog=new Dog();
//dog.MakeNoise();

const double pi = 3.14;                     //definirea unei CONSTANTE (nu o poti schimba)
//pi = 1.24;                                //eroare



List<Animal> animals = new List<Animal>
{
    new Dog("Toto"),
    new Cat()
};

foreach(var animal in animals)
{
    animal.MakeNoise();
}
public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }
    public virtual void MakeNoise()
    {
        Console.WriteLine("Animal Noise");
    }
}

public class Dog : Animal
{
    public Dog (string name) : base(name) {  }   //apelezi constructorul din clasa de baza (poti seta un nume de animal, indiferent daca e dog sau cat)

    public void GoOut()
    {
        Console.WriteLine("Go out.");
    }
    public override void MakeNoise()
    {
        //base.MakeNoise();                       //poti sau nu apela la "base."
        Console.WriteLine("Dog noise");         //poti sa le inversezi, cum doresti
    }
}

public class Cat : Dog
{
    public Cat():base("Unknown cat") { }
    public override void MakeNoise()
    {
        Console.WriteLine("Cat noise.");
    }
}*/

/*CityNames myCity = (CityNames)5;         //e CUSTOM   sau    = CityNames.Botosani;

Teacher2 alex = new Teacher2
{
    FirstName = "Mihai",
    LastName = "Popescu",
    Age = 42,
    Gender = "FEMale",
    CyteName = CityNames.Botosani
};
public enum CityNames                     // ENUMS (sunt enumarari de constante) - trebuie sa pui acces modifier
{
    Botosani=5,                           //fiecare valoare are un INDEX (incep de la 0 sau PREFERENTIAL daca pui =VALOARE)
    Iasi,
    Suceava,
    Vaslui
}*/



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


/*Manager john = new Manager("John", "Doe", 50000);
RegularEmployee jane = new RegularEmployee("Jane", "Smith", 30000);

john.AddEmployee(jane);

Console.WriteLine(john.GetFullName()); // Outputs "John Doe"
Console.WriteLine(jane.GetFullName()); // Outputs "Jane Smith"

Console.WriteLine(john.GetMonthlySalary()); // Outputs 4166.66666666667
Console.WriteLine(jane.GetMonthlySalary()); // Outputs 2500

Console.WriteLine(john.GetTotalMonthlySalary()); // Outputs 6666.66666666667*/








//HOMEWORK WEEK5-OOP Advanced


//Exercise 1


/*BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);

myAccount.Deposit(500);
myAccount.Withdraw(200);

Console.WriteLine(myAccount.GetBalance()); // Outputs 1300

List<Transaction> transactions = myAccount.GetTransactionHistory();
foreach (Transaction transaction in transactions)
{
    Console.WriteLine($"{transaction.Timestamp}: {transaction.Type} ${transaction.Amount}");
}


// Outputs:
//[Timestamp of first transaction]: Deposited $500
//[Timestamp of second transaction]: Withdrew $200

myAccount.AccountNumber = 654321;
myAccount.AccountHolder = "Jane Smith";

Console.WriteLine(myAccount.AccountNumber); // Outputs 654321
Console.WriteLine(myAccount.AccountHolder); // Outputs "Jane Smith"*/


//Exercise 2

/*Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

Console.WriteLine(book.GetTitle()); // Outputs "The Great Gatsby"
Console.WriteLine(book.GetAuthor()); // Outputs "F. Scott Fitzgerald"
Console.WriteLine(book.GetPageCount()); // Outputs 180
Console.WriteLine(book.GetCurrentPage()); // Outputs 1

book.NextPage();
Console.WriteLine(book.GetCurrentPage()); // Outputs 2

book.NextPage();
book.NextPage();
book.NextPage();
Console.WriteLine(book.GetCurrentPage()); // Outputs 5

book.PreviousPage();
Console.WriteLine(book.GetCurrentPage()); // Outputs 4

book.Title = "The Great Gatsby (Revised Edition)";
Console.WriteLine(book.GetTitle()); // Outputs "The Great Gatsby (Revised Edition)"

book.Author = "F. Scott Fitzgerald (Revised by Jane Doe)";
Console.WriteLine(book.GetAuthor()); // Outputs "F. Scott Fitzgerald (Revised by Jane Doe)"*/


//Exercise 3

/*Rectangle rectangle1 = new Rectangle("Green", 6, 8);
Rectangle rectangle2 = new Rectangle("Yellow", 10, 12);

Circle circle1 = new Circle("Purple", 3);
Circle circle2 = new Circle("Orange", 5);

List<Shape> shapes = new List<Shape> { rectangle1, rectangle2, circle1, circle2 };

foreach (Shape shape in shapes)
{
    shape.CalculateArea();
}

shapes.Sort((shape1, shape2) => shape2.Area.CompareTo(shape1.Area));

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Color + ": " + shape.GetPerimeter());
}

*//*Outputs:
Yellow: 120
Purple: 28.2743338823081
Orange: 78.5398163397448
Green: 48*//*


double totalPerimeter = 0;
foreach (Shape shape in shapes)
{
    totalPerimeter += shape.GetPerimeter();
}

Console.WriteLine("Total perimeter: " + totalPerimeter + " inches"); // Outputs "Total perimeter: 244.964101615137 inches"*/


//Exercise 4

/*Manager manager = new Manager("John Doe", 35, 50000, Department.IT);
Developer developer = new Developer("Jane Smith", 28, 30000, new List<string> { "C#", "JavaScript" }, false);

Console.WriteLine(manager.CalculateBonus()); // Outputs 5000
Console.WriteLine(developer.CalculateBonus()); // Outputs 6000

Console.WriteLine(manager.GetContactInfo()); // Outputs "Name: John Doe, Age: 35, Department: IT, Email: john.d*/



//Exercise 5

/*BankAccount account1 = new BankAccount("123456", "John Doe", 1000);
BankAccount account2 = new BankAccount("654321", "Jane Smith", 2000);

account1.Deposit(500);
account2.Withdraw(1000);

Console.WriteLine(account1.Balance); // Outputs 1500
Console.WriteLine(account2.Balance); // Outputs 1000

Console.WriteLine(account1.GetInterest()); // Outputs 15
Console.WriteLine(account2.GetInterest()); // Outputs 20

Console.WriteLine(Bank.NumAccounts); // Outputs 2*/




//Exercise 6

/*IShape circle = new Circle(5);
IShape rectangle = new Rectangle(10, 5);

Console.WriteLine(circle.CalculateArea()); // Outputs 78.5398163397448
Console.WriteLine(rectangle.CalculateArea()); // Outputs 50

Console.WriteLine(circle.CalculateArea("square feet")); // Outputs "Area: 78.5398163397448 square feet"
Console.WriteLine(rectangle.CalculateArea("square meters")); // Outputs "Area: 50 square meters"

IColor circleColor = (IColor)circle;
circleColor.Color = "Red";

IColor rectangleColor = (IColor)rectangle;
rectangleColor.Color = "Blue";

Console.WriteLine(circleColor.Color); // Outputs "Red"
Console.WriteLine(rectangleColor.Color); // Outputs "Blue"*/



//Exercise 7

Hotel orient = new Hotel("Orient", 2532124, Cities.Ploiesti, "Calea Dorobantilor", 15, 18);
orient.NumberOfSingleRooms=12;
orient.NumberOfDoubleRooms=26;
orient.SetCheckInTime("15:00");
orient.SetCheckOutTime("11:00");
orient.SetPriceSingleRoom(109);
orient.RemoveEmployee(1);
orient.PrintInfo();
Console.WriteLine();

Hotel cantemir = new Hotel("Cantemir", 352124, Cities.Oradea, "Bulevardul Taberei", 62,22);
cantemir.NumberOfSingleRooms=8;
cantemir.NumberOfDoubleRooms=32;
cantemir.NumberOfApartments=14;
cantemir.SetCheckInTime("14:00");
cantemir.SetCheckOutTime("10:00");
cantemir.SetPriceApartment(449);
cantemir.AddEmployee(1);
cantemir.PrintInfo();
Console.WriteLine();

Motel bucegi = new Motel("Bucegi", 893235, Cities.Arad, "Str. Triumfului", 82,8);
bucegi.NumberOfSingleRooms=4;
bucegi.NumberOfDoubleRooms=8;
bucegi.SetCheckInTime("11:00");
bucegi.SetCheckOutTime("18:00");
bucegi.PrintInfo();
Console.WriteLine();
