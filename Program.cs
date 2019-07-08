using System;
using c_expRestSharp.Requests.LeaveType;
using c_expRestSharp.Requests.Person;

namespace c_expRestSharp
{
    class Program
    {  
        
        static void Main(string[] args)
        {
            GetAuth auth = new GetAuth();

            //(new All()).all();
            (new GetList()).getList();
        }
    }
}
