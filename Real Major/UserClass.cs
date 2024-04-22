using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Major
{
    public class UserClass
    {
        public int userID { get; private set; }
        public string username { get; private set; } = string.Empty;

        public string firstName { get; private set; } = string.Empty;

        public int roleID { get; private set; }

        public UserClass(int userID, string username, int roleID)
        {
            this.userID = userID;
            this.username = username;
            //this.firstName = firstName;
            this.roleID = roleID;
        }


    }

}