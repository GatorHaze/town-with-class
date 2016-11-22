using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town_with_class
{
    class school
    {
        string BuildingType { get; set; }
        string constructionMaterial { get; set; }
        int NumberOfRoom { get; set; } = 1;
        double height { get; set; } = 0d;
        double width { get; set; } = 0d;
        double length { get; set; } = 0d;
        int floors { get; set; }
        int BathRooms { get; set; }

        string Volume { get; }
        string Address { get; } = "Address1, Address2, city, state, zip";
        int currentOcc { get; } = 0;
        int numberOfStudents { get; set; }
        int numberOfTeachers { get; set; }

        string squareFootage { get; }
    }

}