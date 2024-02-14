namespace DotnetFormat
{
    public class Customer
    {
        public string FirstName         { get; set; }

        public string LastName                      { get; set; }

        public int Age { get;                set; }

        public string Email { get; set; }

        public Customer(string firstName, string lastName, int age, string email)
        {
                FirstName = firstName;
            LastName =  lastName;
            Age = age;
            Email = email;
        }

    }   
}
