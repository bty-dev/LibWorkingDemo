using AgeLimiterLibrary;

AgeLimiter ageLim = new AgeLimiter(19);
ageLim.checkAge();
var ageCategory = ageLim.amIOld();
Console.WriteLine(ageCategory);

var randAge = ageLim.getRandomAge();
Console.WriteLine($"Here is random age: {randAge}");

Console.WriteLine("Thanks for downloading my lib! :)");