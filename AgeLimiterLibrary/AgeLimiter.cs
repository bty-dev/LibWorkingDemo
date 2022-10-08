namespace AgeLimiterLibrary
{
    public class AgeLimiter
    {
        int age;

        public AgeLimiter(int age)
        {
            this.age = age;
        }
        public void checkAge() => Console.WriteLine($"Your age is: {age}");

        public string amIOld()
        {
            var result = this.age > 18 ? "You old!" : "You young!";
            return result;
        }

        public int getRandomAge()
        {
            Random random = new Random();
            var result = random.Next(100);
            return result;
        }

    }
}