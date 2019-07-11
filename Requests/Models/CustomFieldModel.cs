using System.Collections.Generic;
namespace KolayCsharp_Client.Requests.Models
{
 public class CustomFieldsModel
 {
    public class CustomField
    {
        public string type {get; set;}
        public string label { get; set; }
        public string name { get; set; }
    }

    public class CustomFieldRequest: Request
    {
        public CustomField fields { get; set; }

    }
 }
}