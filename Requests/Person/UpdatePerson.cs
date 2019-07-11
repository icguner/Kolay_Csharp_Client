using KolayCsharp_Client.Requests.Models;

namespace KolayCsharp_Client.Requests.Person
{
    public class UpdatePerson: GetAuth
    {
        public void updatePerson()
        {
          
            var Query = new PersonModel.PersonRequest
            {
                person = new Requests.Models.PersonModel.Person {
                id = "f4e421a216aeb0ba0f503fd5224cdd09",
                firstName = "Kolay",
                lastName = "IK",
                workEmail = "test@kolayik.com",
                email = null,
                employmentType = "fulltime",
                workingDayId = null,
                accessType = "employee",
                sendWelcomeEmail = false,
                mobilePhone = "555555555",
                workPhone = "555555556",
                tourStatus = "passive",
                managerId = "3",
                employmentStartDate = "2019/06/28"
                }
            };
            (new KolayClient(client)).POST("/person/general-info", Query);
        }
    }
}