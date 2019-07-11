using System.Collections.Generic;
namespace KolayCsharp_Client.Requests.Models
{
 public class PersonModel
 {
    public class Person
    {
        public string id {get; set;}
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string workEmail { get; set; }
        public string email { get; set; }
        public string employmentType { get; set; }
        public string workingDayId { get; set; }
        public string accessType { get; set; }
        public bool sendWelcomeEmail {get; set;}
        public string mobilePhone { get; set; }
        public string workPhone { get; set; }    
        public string tourStatus { get; set; }
        public string managerId { get; set; }
        public string employmentStartDate { get; set; }
    }

    public class PersonRequest: Request
    {
        public Person person { get; set; }

    }

 }

public class Request
{
    
}

}