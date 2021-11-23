using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DB
    {
        public string ConnStr { get; }
        public DB()
        {
            ConnStr = "server=boundsoul1937.asuscomm.com;port=80;database=Ejendomsmægler;user=LicenseConnect;password=test12341234;SslMode=none;";
        }  
    }
}
