using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy_Records
{
    static public class User
    {
        static private int secure;
        static private string id;
        static public int clrnce()
        {
            return secure;
        }
        static public string person()
        {
            return id;
        }
        static public void setdat(int sec,string us)
        {
            secure = sec;
            id = us;
        }
    }
}
