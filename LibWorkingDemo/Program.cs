using AgeLimiterLibrary;

AgeLimiter ageLim = new AgeLimiter(19);
ageLim.checkAge();
var ageCategory = ageLim.amIOld();
Console.WriteLine(ageCategory);