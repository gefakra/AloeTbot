using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Aloe_Telegram_FatTest
{
   public class GeoPosition
    {
        public bool IsVariants { get; set; } = false;
        public int Status { get; set; }
        public string Region_Name { get; set; }
        public string Sity { get; set; }
        public string Street { get; set; }
        public int Home { get; set; }
        public long? Longitude { get; set; }
        public long? Latitude { get; set; }

        public void AddRegion(string msg)
        { 
            switch(msg)
            {
                case "Моё место положение":
                   
                    break;
                case "Санкт-Петербург":
                    Status = 1;
                    Region_Name = "Санкт-Петербург";
                    Sity = "Санкт-Петербург";
                    IsVariants = false;
                    break;
                default:                    
                    IsVariants = false;
                    Status = 3;
                    var t = msg.Split(new char[] {';'}).Select(x=> long.Parse(x)).ToArray();
                    Latitude = t[0];
                    Longitude = t[1];
                    break;

            }
        
        }

        public void Сlear()
        {           
            IsVariants = false;
            Status = 0;
            Home = 0;
            Sity = string.Empty;
            Region_Name = string.Empty;
            Street = string.Empty;
        }
        



    }
}
