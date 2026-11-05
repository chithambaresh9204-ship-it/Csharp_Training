using System;
public class Inheritance
{
    class Animal
    {
        public void DisplayAnimalDetails(String Name, int Age)
        {
            Console.WriteLine("Animal Name: "+Name);
            Console.WriteLine("Age: "+Age);
        }   
    }
    class Dog : Animal
    {
        public void CalculateFoodQuantity(String Breed, double Weight)
        {
            Console.WriteLine("Breed: "+Breed);
            Console.WriteLine("Daily Food Required: "+Weight*20+"grams");
        } 
    }
    class Puppy : Dog
    {
        public void CheckVaccinationStatus(int VaccinationCount, int GrowthMonths)
        {
            Console.WriteLine("Vaccination Count: "+VaccinationCount);
            if (VaccinationCount < 3)
            {
                Console.WriteLine("Status: Vaccination Pending");
            }
            else
            {
                Console.WriteLine("Status: Vaccination Completed");
            }
        }
    }
    static void Main(String[] args)
    {
        Puppy p=new Puppy();
        p.DisplayAnimalDetails("Tommy",10);
        p.CalculateFoodQuantity("Labrdor",5);
        p.CheckVaccinationStatus(3,5);
        
    }
}