using FreeExerciseOOP;
using System;
//using FreeExerciseOOP.Exercise1;
//using FreeExerciseOOP.Exercise2;
//using FreeExerciseOOP.Exercise3;
//using FreeExerciseOOP.Exercise4;
//using FreeExerciseOOP.Exercise5;
//using FreeExerciseOOP.Exercise6;
//using FreeExerciseOOP.Exercise7;


/* Exercise 1

Create a C# program that requests three names of people from the user and stores them in an array of objects of type Person.
To do this, first create a Person class that has a Name property of type string and override the ToString() method.

End the program by reading people and executing the ToString() method on the screen.*/


/*Person[] persons = new Person[3];
for(int i = 0; i < 3; i++)
{
    Console.Write("Insert person name:");
    persons[i] = new Person();
    persons[i].Name = Console.ReadLine();
}
for(int i = 0;i< persons.Length; i++)
{
    Console.WriteLine(persons[i].ToString());
}*/


/*Exercise 2

Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. 
To do this, first create a Person class that has a Name property of type string, 
   a constructor that receives the name as a parameter, a destructor that assigns 
   the name to empty and overwrites the ToString () method.

End the program by reading the people and executing the ToString () method on screen.*/

/*Person[] persons = new Person[3];
for (int i = 0; i < 3; i++)
{
    Console.Write("Insert person name:");
    persons[i] = new Person(Console.ReadLine());
}
for (int i = 0; i < persons.Length; i++)
{
    Console.WriteLine(persons[i].ToString());
}*/

//Exercise 3

/*Create a new C # project with three classes plus another class to test the logic in your code. 
The main classes of the program are the following classes: Person, Student, Teacher
The Student and Teacher classes inherit from the Person class.
The Student class will include a public Study() method that will write I'm studying on the screen.
The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.
The Teacher class will include a public Explain() method that will write I'm explaining on the screen.
Also create a public method ShowAge() in the Student class that writes My age is: x years old on the screen.
You must create another test class called Program with a Main method to do the following:

Create a new Person and make him say hello
Create a new Student, set an age, say hello, and display her age on the screen.
Create a new Teacher, set an age, say hello and start the explanation.*/

/*Person alex = new Person();
alex.Greet();

Student mihai= new Student();
mihai.SetAge(24);
mihai.Greet();
mihai.ShowAge();

Teacher cristian= new Teacher();
cristian.SetAge(44);
cristian.Greet();
cristian.Explain();*/


//Exercise 4

/*Create a C# program to manage a photo book using object-oriented programming.
To start, create a class called PhotoBook with a private attribute numPages of type int. 
It must also have a public method GetNumberPages that will return the number of photo book pages.
The default constructor will create an album with 16 pages. 
There will be an additional constructor, with which we can specify the number of pages we want in the album.
There is also a BigPhotoBook class whose constructor will create an album with 64 pages.
Finally create a PhotoBookTest class to perform the following actions:
Create a default photo book and show the number of pages
Create a photo book with 24 pages and show the number of pages
Create a large photo book and show the number of pages*/

/*PhotoBook newPhotobook=new PhotoBook();
Console.WriteLine("Number of pages: " + newPhotobook.GetNumberPages());

PhotoBook secondPhotoBook=new PhotoBook(24);
Console.WriteLine("Number of page's second photo book: "+secondPhotoBook.GetNumberPages());

BigPhotoBook bigPhotoBook = new BigPhotoBook();
Console.WriteLine("Number of page's large photo book : " + bigPhotoBook.GetNumberPages());*/


//Exercise 5

/*Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects.
There will be two people of the Student type and one person of the Teacher type.
To do this, create a Person class that has a Name property of type string, a constructor 
    that receives the name as a parameter and overrides the ToString () method.
Then create two more classes that inherit from the Person class, they will be called Student and Teacher. 
   The Student class has a Study method that writes by console that the student is studying. 
    The Teacher class will have an Explain method that writes to the console that the teacher is explaining. 
    Remember to also create two constructors on the child classes that call the parent constructor of the Person class.

End the program by reading the people (the teacher and the students) and execute the Explain and Study methods.*/

/*Person[] persons = new Person[3];
for (int i = 0; i < 3; i++)
{
    Console.Write("Insert person name:");
    persons[i] = new Person(Console.ReadLine());
}
for (int i = 0; i < persons.Length; i++)
{
    Console.WriteLine(persons[i].ToString());
}

Teacher firstTeacher = new Teacher("Alex");
firstTeacher.Explain();

Student firstStudent = new Student("Mihaita");
firstStudent.Study();*/

//Exercise 6

/*Create a C# program that represents the following UML class diagram.  
https://www.exercisescsharp.com/oop/shapes-class-diagram
The diagram represents public, private, and protected attributes as well as class dependency and inheritance.
Class diagram: Shapes*/

//Exercise 7

/*Create a C# program that implements an abstract class Animal that has a Name property of type text and 
        three methods SetName (string name), GetName and Eat. 
    The Eat method will be an abstract method of type void.

You will also need to create a Dog class that implements the above Animal class and the Eat 
    method that says the dog is Eating.

To test the program ask the user for a dog name and create a new Dog type object from the 
    Main of the program, give the Dog object a name, and then execute the GetName and Eat methods.*/

/*Dog firstDog = new Dog();
Console.Write("Insert dog name: ");
firstDog.SetName(Console.ReadLine());
Console.WriteLine("Dog's name is: " + firstDog.GetName());
firstDog.Eat();*/