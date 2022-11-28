using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 컨트롤러 같은 것
namespace ParkingCarManager
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();

        static DataManager()
        {
            Load();
        }

        public static void Load()
        {

        }

        public static void PrintLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("ParkingHistory");
            if(di.Exists == false)
            {
                di.Create();
            }
            using (StreamWriter w = new StreamWriter("ParkingHistory\\ParkingHistory.txt", true))
            {
                w.WriteLine(contents);
            }
        }
    }
}
