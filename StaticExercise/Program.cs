using StaticExercise;

var answer = TempConverter.FahrenheitToCelcius(87);
Console.WriteLine(answer);


var answer2 = TempConverter.CelciusToFahrenheit(0);
Console.WriteLine(answer2);

Console.WriteLine("Enter in Fahrenheit to be converted to Celcius");
var userInput = double.Parse(Console.ReadLine());

var answer3 = TempConverter.FahrenheitToCelcius(userInput);
Console.WriteLine($"{userInput} degrees Fahrenheit is {answer3} degrees Celcius");
