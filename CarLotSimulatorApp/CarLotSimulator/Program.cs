﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
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
            //Call each of the methods for each car

            Car subuwu = new Car();
            subuwu.Year = 2023;
            subuwu.Make = "Subaru";
            subuwu.Model = "Crosstrek";
            subuwu.EngineNoise = "Vroooooooommmmmmm";
            subuwu.HonkNoise = "Beep boop";
            subuwu.IsDriveable = true;

            subuwu.MakeEngineNoise();
            subuwu.MakeHonkNoise();

            Car suburu = new Car() { Year = 2012, Make = "Suburu", Model = "Outback", EngineNoise = "Vrum", HonkNoise = "Bep"};

            suburu.MakeEngineNoise();
            suburu.MakeHonkNoise();


            Car miniCooper = new Car(2024,"Mini Cooper","Hatchback","VREEEEM","Beepidy Boopidy");

            miniCooper.MakeEngineNoise();
            miniCooper.MakeHonkNoise();



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
