using KolayCsharp_Client.Requests.Models;

namespace KolayCsharp_Client.Requests.Person
{
    public class CreatePerson: GetAuth
    {
        public void createPerson()
        {
          
            var Query = new PersonModel.PersonRequest
            {
                person = new Requests.Models.PersonModel.Person 
                {
                firstName = "Kolay",
                lastName = "IK",
                workEmail = "test@kolayik.com",
                email = null,
                employmentType = "fulltime",
                workingDayId = null,
                accessType = "employee",
                sendWelcomeEmail = false,
                mobilePhone = "",
                workPhone = "",
                tourStatus = "passive",
                managerId = "",
                employmentStartDate = "2019/06/28"
                }
            };
            (new KolayClient(client)).POST("/person/general-info", Query);
        }
    }
}