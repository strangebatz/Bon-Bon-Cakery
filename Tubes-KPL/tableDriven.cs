using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    class tableDriven
    {
        public enum uname { sova, cypher, admin, diluc, omen, breach, reyna,
            user
        }
        public static string[] password = { "hunter", "corpse", "admin", "retribution", "shadow", "blinding", "empress" };
        public static string getUser(uname userName)
        {
            return password[(int)userName];
        }
    }
    }

