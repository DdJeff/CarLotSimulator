using System;

namespace CarLotSimulator
{   public class Car
    {
        public static int numberOfCars = 0;
       
        public int Year { get; set; }
        public string Make { get; set; }

        public  string Model { get; set; }
        public  string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool isDriveable { get; set; }

        //default constructor
        public Car()
        {
            numberOfCars++;
        }
        public Car(int Year,string Make, string Model, string EngineNoise, string HonkNoise, bool isDriveable)
        {
            this.Year = Year;
            this.Make = Make;
            this.Model = Model;
            this.EngineNoise = EngineNoise;
            this.HonkNoise = HonkNoise;
            this.isDriveable = isDriveable;
                 numberOfCars++;
        }
        public void MakeEngineNoise(string noise) {Console.WriteLine(noise); }


        public void MakeHonkNoise(string hornNoise) { Console.WriteLine(hornNoise); }
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car

            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each cars

            Console.WriteLine(Car.numberOfCars + " " + "this is the beginning");

            Car myCar = new Car(2007,"Honda", "Oddessy","clank", "beep", true );

            Console.WriteLine(Car.numberOfCars + " " + "this is the middle");

            Car mySecondCar = new Car { Year = 2009, Make = "Kia", Model = "Rio", EngineNoise = "None", HonkNoise = "beep beep", isDriveable = true};

            Console.WriteLine(Car.numberOfCars + " " + "this is the middle");

            Car myThirdCar = new Car();
            myThirdCar.Year = 2022;
            myThirdCar.Make = "Hyndia";
            myThirdCar.Model = "Elantra";
            myThirdCar.EngineNoise = "none";
            myThirdCar.HonkNoise = "Beep beep beep";
            myThirdCar.isDriveable = false;

            myCar.MakeEngineNoise("clank");
            myCar.MakeHonkNoise("beep");

            mySecondCar.MakeEngineNoise("clank");
            mySecondCar.MakeHonkNoise("beep");
            myThirdCar.MakeEngineNoise("clank");
            myThirdCar.MakeHonkNoise("beep");

            Console.WriteLine(Car.numberOfCars + " " + "this is the end");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


        }
    }
}
