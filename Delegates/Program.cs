//It creates a specific method that matches with CalculateMidPointDelegate input parameters
using Delegates;
using System.Linq;
using System.Text.RegularExpressions;

int CalculateMidPoint(int y, int z) 
{
    return (int)Math.Floor((float)(y + z) / 2);
}

//Func delegate
Func<int, int, int> midPointAnonymous = (y, z) => (int)Math.Floor((float)(y + z) / 2);

//Creating CalculateMidPointDelegate as a variable to generate an instance, passing a method that matches with
CalculateMidPointDelegate midPoint = new(CalculateMidPoint);

//Creating CalculateMidPointDelegate as a variable to generate an instance, passing Func variable that matches with
CalculateMidPointDelegate midPoint2 = new(midPointAnonymous);

//Invoking instances that represents a method
Console.WriteLine("Calculate midPoint with delegate and a specific method: " + midPoint(10, 20));
Console.WriteLine("Calculate midPoint with delegate and an anonymous method: " + midPoint2(10, 20));
Console.WriteLine("Calculate midPoint with Func: " + midPointAnonymous(10,20));


//Creating an instance of Animal
Animal animal = new Animal();

////Getting animals from json
var animals = animal.DeserielizeAnimals();

////Using a method that receives a Func as input parameter
animal.GetAnimals(animals, x => x.Name.ToLower().Split().Intersect(x.ScientificName.ToLower().Split()).Any());

animal.GetAnimalsFromJsonWithIQueryable(x => x.Name.ToLower().Split().Intersect(x.ScientificName.ToLower().Split()).Any());

Console.WriteLine("");


//It creates a delegate that receives two ints as input parameter
public delegate int CalculateMidPointDelegate(int a, int b);