using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetofinaldnv.Models
{
    public class UserSession
    {
        private static int userId;

        public static void SetUserId(int userId)
        {
            UserSession.userId = userId;
        }

        public static int GetUserId()
        {
            return UserSession.userId;
        }
    }
}
