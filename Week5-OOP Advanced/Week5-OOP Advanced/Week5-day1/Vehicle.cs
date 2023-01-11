namespace Week5_OOP_Advanced
{
    public abstract class Vehicle                   //daca ai metoda abstracta => clasa trebuie sa fie clasa abstracta
    {                                               //clasa abstracta NU poate fi instantiata(nu poti crea obiecte);
        public string Color { get; set; }
        public string Name { get; set; }
        public int NumberOfWheels { get; set; }

        public abstract void Start();               //prin metoda ABSTRACTA OBLIGI persoana care mosteneste metoda sa o implementeze
    }

    public class AudiVehicle : Vehicle          //ia tot ce e public si protected
    {
        public override void Start()                    //OBLIGATORIU sa ai OVERRIDE
        {         
            Console.WriteLine("Audi start");
        }
    }

    public class FordVehicle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Ford Start");
        }
    }
}
