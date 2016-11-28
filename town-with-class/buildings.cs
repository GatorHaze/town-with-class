using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town_with_class
{
    public class buildings
    {
        public string BuildingType { get; set; }
        public string BuildingType(string brick, string concrete, string wood)

        public buildings()
        {

        }
        string constructionMaterial { get; set; }
        int NumberOfRoom { get; set; } = 1;
        double height { get; set; } = 0d;
        double width { get; set; } = 0d;
        double length { get; set; } = 0d;
        int floors { get; set; }
        int BathRooms { get; set; }
        int currentOcc { get; } = 0;

        public string address1 = "N/A";
        private string address2 = "N/A";
        private string city = "N/A";
        private string state = "N/A";
        private int zip = 0;
        public string Address1
        {
            get
            {
                return address1;
            }
        }
        public string Address2
        {
            get
            {
                return address2;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
        }
        public string State
        {
            get
            {
                return state;
            }
        }
        public int Zip
        {
            get
            {
                return zip;
            }
        }
        public override string ToString()
        {
            return "Address1 = " + Address1 + ", Address2 = " + Address2 + "City = " + City + "State = " + State + "Zip = " + Zip;
        }
    
        int Volume { get; }
        int squareFootage { get; }

    }
}
