        //Exercise 1
    System.Console.Write("Introduceti primul numar:");
    double firstNumber=Convert.ToDouble(System.Console.ReadLine());
    System.Console.Write("Introduceti al doilea numar:");
    double secondNumber=Convert.ToDouble(System.Console.ReadLine());
    double addition=firstNumber+secondNumber;
    double substraction=firstNumber-secondNumber;
    double division=firstNumber/secondNumber;
    double multiplication=firstNumber*secondNumber;
    System.Console.WriteLine("Addition = "+addition);
    System.Console.WriteLine("Substraction = "+substraction);
    System.Console.WriteLine("Division = {0}",division);
    System.Console.WriteLine("Multiplication = {0}",multiplication);

        //Exercise 2
    System.Console.WriteLine("Introduceti primul numar:");
    int num1=Convert.ToInt32(System.Console.ReadLine());
    System.Console.WriteLine("Introduceti al doilea numar:");
    int num2=Convert.ToInt32(System.Console.ReadLine());
    System.Console.WriteLine("Introduceti al treilea numar:");
    int num3=Convert.ToInt32(System.Console.ReadLine());
    if(num1>num2 && num1>num3){
    System.Console.WriteLine("Maximum number is: {0}",num1);
    }else if(num1>num2 && num1<num3){
    System.Console.WriteLine("Maximum number is: {0}",num3);
    }
    if(num2>num1 && num2>num3){
    System.Console.WriteLine("Maximum number is: {0}",num2);
    }else if(num2>num1 && num2<num3){
    System.Console.WriteLine("Maximum number is: {0}",num3);
    }

    //Exercise 3:
    System.Console.WriteLine("Introduceti numarul zilelor pentru a fi convertit:");
    int days=Convert.ToInt32(System.Console.ReadLine());
    if(days/365!=0){
        int years=days/365;
        if(years>1){
                System.Console.Write("{0} years, ",years);
        } else  System.Console.Write("{0} year, ",years);
    days=days-years*365;//sau days-=years*days;
    } 
    if(days/30!=0){
        int months=days/30;
        if(months>1){
                System.Console.Write("{0} months, ",months);
        } else  System.Console.Write("{0} month, ",months);
    days=days-months*30;//sau days-=months*days;
    }
    if(days/7!=0){
        int weeks=days/7;
        if(weeks>1){
                System.Console.Write("{0} weeks, ",weeks);
        } else  System.Console.Write("{0} week, ",weeks);
    days=days-weeks*7;//sau days-=weeks*days;
    }
    if(days>1){
         System.Console.Write("{0} days",days);
        } else  System.Console.Write("{0} day",days);


    //Exercise 5
    System.Console.Write("Enter the Physics mark: ");
    byte physicsGrade=Convert.ToByte(System.Console.ReadLine());
    System.Console.Write("Enter the Chemistry mark: ");
    byte chemistryGrade=Convert.ToByte(System.Console.ReadLine());
    System.Console.Write("Enter the Biology mark: ");
    byte biologyGrade=Convert.ToByte(System.Console.ReadLine());
    System.Console.Write("Enter the Mathematics mark: ");
    byte mathematicsGrade=Convert.ToByte(System.Console.ReadLine());
    System.Console.Write("Enter the Computer Science mark: ");
    byte computerScienceGrade=Convert.ToByte(System.Console.ReadLine());
    double percentage= (physicsGrade+chemistryGrade+biologyGrade+mathematicsGrade+computerScienceGrade)/5;
    if(percentage>=90){
            System.Console.WriteLine("Percentage = {0} and grade is A.",percentage);
    }
    else if(percentage>=80){
            System.Console.WriteLine("Percentage = {0} and grade is B.",percentage);
    }
    else if(percentage>=70){
            System.Console.WriteLine("Percentage = {0} and grade is C.",percentage);
    }
    else if(percentage>=60){
            System.Console.WriteLine("Percentage = {0} and grade is D.",percentage);
    }
    else if(percentage>=40){
            System.Console.WriteLine("Percentage = {0} and grade is E.",percentage);
    }
    else if(percentage<40){
            System.Console.WriteLine("Percentage = {0} and grade is F.",percentage);
    }

        //Exercise 6
    System.Console.Write("Enter the grade: ");
    char grade=Convert.ToChar(Console.ReadLine());
    if(grade=='E'){
        System.Console.WriteLine("Excellent");
    }
    else if(grade=='V'){
        System.Console.WriteLine("Very Good");
    }
    else if(grade=='G'){
        System.Console.WriteLine("Good");
    }
    else if(grade=='A'){
        System.Console.WriteLine("Average");
    }
    else if(grade=='F'){
        System.Console.WriteLine("Fail");
    }

        //Exercise 7