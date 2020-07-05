using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    [Serializable]
    public class Drivers
    {
        public List<Driver> DriversList = new List<Driver>();
    }

    [Serializable]
    public class Driver
    {
        private string dName;
        private string dSurname;
        private string dThirdname;

        public int wayNumber;
        public int busNumber;
        public int busPosition;

        public bool isDel = false;
        public Driver(string uName, string uSurname, string uThirdname, int uWay, int uBusNum, int uBusPos)
        {
            this.DName = uName;
            this.DSurname = uSurname;
            this.dThirdname = uThirdname;
            this.wayNumber = uWay;
            this.busNumber = uBusNum;
            this.busPosition = uBusPos;
        }

        public string DName
        {
            get { return dName; }
            set { dName = value; }
        }
        public string DSurname
        {
            get { return dSurname; }
            set { dSurname = value; }
        }
        public string DThirdname
        {
            get { return dThirdname; }
            set { dThirdname = value; }
        }
    }
}
