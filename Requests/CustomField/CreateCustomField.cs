using KolayCsharp_Client.Requests.Models;

namespace KolayCsharp_Client.Requests.CustomField
{
    public class CreateCustomField: GetAuth
    {
        public void createCustomField()
        {
          
            var Query = new CustomFieldsModel.CustomFieldRequest
            {
                fields = new Requests.Models.CustomFieldsModel.CustomField 
                {
                type = "textarea",
                label = "selamcanim",
                name = "35039503kfAF30f343"
                }
            };
            (new KolayClient(client)).POST("/company/custom-fields", Query);
        }
    }
}