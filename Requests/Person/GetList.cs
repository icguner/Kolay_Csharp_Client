namespace c_expRestSharp.Requests.Person
{
    public class GetList: GetAuth
    {
        public void getList()
        {
            (new KolayClient(client)).POST("/person/search",
            ("page","1"),
            ("q", "2"),
            ("status", "1"),
            ("units", "[aec21ed314135a843493e24dba77302d],[592598f80d173507d2f9963e1d53c2e1]")
            );
        }
    }
}