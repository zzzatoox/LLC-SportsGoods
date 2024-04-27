using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLC_SportsGoods.Classes
{
    internal class UserData
    {
        public static int userId { get; set; }
        public static string lastName { get; set; }
        public static string firstName { get; set; }
        public static string patronymic { get; set; }
        public static int roleId { get; set; }

        public UserData(SqlDataReader reader)
        {
            userId = reader.GetInt32(0);
            lastName = reader.GetString(1);
            firstName = reader.GetString(2);
            patronymic = reader.GetString(3);
            roleId = reader.GetInt32(6);
        }
    }
}
