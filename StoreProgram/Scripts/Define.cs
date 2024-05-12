using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Define
{
    public class UserInfo
    {
        public string ID { get; set; }
        public string PW { get; set; }
        public string Authority { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public static void SetUserInfo(MySqlDataReader reader, UserInfo userInfo)
        {
            userInfo.ID = reader["id"].ToString();
            userInfo.PW = reader["pw"].ToString();
            userInfo.Authority = reader["authority"].ToString();
            userInfo.Name = reader["name"].ToString();
            userInfo.PhoneNumber = reader["phoneNumber"].ToString();
            userInfo.Address = reader["address"].ToString();
        }
    }
}