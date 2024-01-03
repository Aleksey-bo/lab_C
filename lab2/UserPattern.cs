using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class UserPattern
    {
        private static UserCard _instance;

        public static UserCard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserCard("FZSCHXVNHLZ4Q8PH", "Jon Doe", "jon@gmail.com", "468504543323445");
                }
                return _instance;
            }
        }
    }
}
