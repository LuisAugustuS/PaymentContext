using System.Collections.Generic;

namespace PaymentContext.Domain.Entities   
{
    public class Student
    {
        public Student(string firstName, string lastname, string document, string email)
        {
            FirstName = firstName;
            Lastname = lastname;
            Document = document;
            Email = email;
        }

        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get; set; }
    }
}