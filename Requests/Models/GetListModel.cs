using System.Collections.Generic;
namespace KolayCsharp_Client.Requests.Models
{
 public class GetListModel
 {
    public class ListModel:Request
    {
      public int page { get; set; }
      public string q  { get; set; }
      public bool status { get; set; }
      public object units { get; set; }
    }

}
}