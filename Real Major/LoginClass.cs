using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Major
{
    public class LoginClass
    {
        public string username { get; private set; } = string.Empty;
        public string hashedPass { get; private set; } = string.Empty;
        public string date { get; private set; } = string.Empty;
        
        public LoginClass(string username, string hashedPass,string date)
        {

        }
    }
    
}
