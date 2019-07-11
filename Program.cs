using System;
using KolayCsharp_Client.Requests.LeaveType;
using KolayCsharp_Client.Requests.Person;
using KolayCsharp_Client.Requests.CustomField;

namespace KolayCsharp_Client
{
    class Program
    {  
        
        static void Main(string[] args)
        {
            GetAuth auth = new GetAuth();
            //(new All()).all();
            //(new GetList()).getList();
            //(new CreatePerson()).createPerson();
            //(new UpdatePerson()).updatePerson();
            //(new GetCustomFields()).getCustomFields();
            (new CreateCustomField()).createCustomField();
        }
    }
}
