using System;
using System.Text;
using System.Linq;

namespace boocksinfo
{
    struct AirLines
    {
        public string number;
        public string city;
        public string time1;
        public string time2;
        public string people;

        public AirLines(string lineWithAllData)
        {

            var arrString = lineWithAllData.Split(' ');

            number = arrString[0];
            city = arrString[1];
            time1 = arrString[2];
            time2 = arrString[3];
            people = arrString[4];




        }
    }
}
