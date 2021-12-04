using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRsueOOP
{
    public class ATS
    {
        int day, mouth, year;
        int idCity; string cityName;
        int timeOfCall;
        long  number;

        public ATS()
        {
        }

        public ATS(int day, int mouth, int year, int idCity, string cityName, int timeOfCall, long number)
        {
            this.day = day;
            this.mouth = mouth;
            this.year = year;
            this.idCity = idCity;
            this.cityName = cityName;
            this.timeOfCall = timeOfCall;
            this.number = number;
        }

        public int Day { get => day; set => day = value; }
        public int Mouth { get => mouth; set => mouth = value; }
        public int Year { get => year; set => year = value; }
        public int IdCity { get => idCity; set => idCity = value; }
        public string CityName { get => cityName; set => cityName = value; }
        public int TimeOfCall { get => timeOfCall; set => timeOfCall = value; }
        public long Number { get => number; set => number = value; }

        public override bool Equals(object obj)
        {
            return obj is ATS aTS &&
                   day == aTS.day &&
                   mouth == aTS.mouth &&
                   year == aTS.year &&
                   idCity == aTS.idCity &&
                   cityName == aTS.cityName &&
                   timeOfCall == aTS.timeOfCall &&
                   number == aTS.number;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(day);
            hash.Add(mouth);
            hash.Add(year);
            hash.Add(idCity);
            hash.Add(timeOfCall);
            hash.Add(number);
            hash.Add(cityName);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return ($"{day}.{mouth}.{year} {cityName}\t:длительность разговора\t {timeOfCall/60} часа(-ов) и {timeOfCall%60} минут(-ы)\t({timeOfCall} мин.).");
        }
    }
}
