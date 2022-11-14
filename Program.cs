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
    System.Console.Write("Enter a month number from 1 to 12: ");
    byte monthNumber=Convert.ToByte(System.Console.ReadLine());
    if (monthNumber>=1 && monthNumber<=12){
    switch(monthNumber){
        case 1:
            System.Console.WriteLine("January");
            break;
        case 2:   
            System.Console.WriteLine("February");
            break;
        case 3:
            System.Console.WriteLine("March");
            break;
        case 4:   
            System.Console.WriteLine("April");
            break;
        case 5:
            System.Console.WriteLine("May");
            break;
        case 6:   
            System.Console.WriteLine("June");
            break;
        case 7:
            System.Console.WriteLine("July");
            break;
        case 8:   
            System.Console.WriteLine("August");
            break;
        case 9:   
            System.Console.WriteLine("September");
            break;        
        case 10:   
            System.Console.WriteLine("Octomber");
            break;        
        case 11:   
            System.Console.WriteLine("November");
            break;        
        case 12:   
            System.Console.WriteLine("December");
            break;
    }
    }
    else {
        System.Console.WriteLine("You entered a wrong number. Enter again a number from 1 to 12.");
    }

        //Exercise 8
    System.Console.Write("Enter the temperature in centigrade from your city: ");
    int temperature=Convert.ToInt16(System.Console.ReadLine());
    if(temperature>=-50 && temperature<=50){
    if(temperature<0){
        System.Console.WriteLine("Freezing weather");
    }
    else if(temperature >=0 && temperature <=10){
        System.Console.WriteLine("Very Cold weather");
    }
    else if(temperature >=10 && temperature <=20){
        System.Console.WriteLine("Cold weather");
    }
    else if(temperature >=20 && temperature <=30){
        System.Console.WriteLine("Normal in Temp");
    }
    else if(temperature >=30 && temperature <=40){
        System.Console.WriteLine("Its hot");
    }
    else if(temperature >= 40){
        System.Console.WriteLine("Its very hot");
        }
    } else {
        System.Console.WriteLine("The temperature entered is extreme! You probably entered it wrong");
    }  

        //Exercise 9

    System.Console.WriteLine("Introduceti primul numar:");
    double num1=Convert.ToDouble(System.Console.ReadLine());
    System.Console.WriteLine("Introduceti al doilea numar:");
    double num2=Convert.ToDouble(System.Console.ReadLine());
    double addition=num1+num2;
    System.Console.WriteLine("Addition: {0}.\n",addition);
    System.Console.WriteLine("Decrese: num1 - num2 = "+ (num1-num2)+".\n");
    double multiplication=num1*num2;
    System.Console.WriteLine("Multiplication: " + multiplication+".\n");
    System.Console.WriteLine("Division: "+(num1/num2)+".\n");
    double modulus=num1%num2;
    System.Console.WriteLine("Modulus: {0}.\n", modulus);
    num1++;num2++;
    System.Console.WriteLine("Incrementation of first number like num1++ is "+num1+" and of second number like num2++ is "+num2+".\n");
    num1--;num2--;//operatiune pentru a reveni la valorile initiale ale lui num1 si num2
    System.Console.WriteLine("Short form of num1=num1+num2 is num1+=num2 and the result is "+ (num1+=num2) +".\n");
    num1-=num2;//operatiune pentru a reveni la valorile initiale ale lui num1 si num2
    System.Console.WriteLine("Short form of num1=num1-num2 is num1-=num2 and the result is "+ (num1-=num2) +".\n");