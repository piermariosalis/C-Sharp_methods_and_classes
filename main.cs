// new istance of the class Random inside library .NET
// new object references to the variable "number" 

Random number = new Random();

// call Next() method inside the previous object number of Random class 
// Next() accepts two parameters: min number and max number(- 1)
// Next(1, 11) method will return a random number between 10 and 50.
int randomized = number.Next(10,51);

Console.WriteLine(randomized);

// try without creating a new istance for non-static method

int newRandom = Random.Next(10,30);

Console.WriteLine(newRandom); // Output an error

// Overload method 
// They accepts more data types and callback methods

string text = "This is text";
int number = 70;



Console.WriteLine(number);
Console.WriteLine(text);
Console.WriteLine(100);
Console.WriteLine("car");