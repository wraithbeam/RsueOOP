using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRsueOOP
{
    public class AtsComparer: IComparer<ATS>
    {
        public enum CompareType
        {
            Minutes,
            CityId
        }

        private CompareType compareType;

        public AtsComparer(CompareType _compareType)
        {
            compareType = _compareType;
        }


        public int Compare(ATS x, ATS y)
        {
            int result = 0;
            switch (compareType)
            {
                case CompareType.CityId:
                    result = x.IdCity.CompareTo(y.IdCity);
                    break;
                case CompareType.Minutes:
                    result = x.TimeOfCall.CompareTo(y.TimeOfCall);
                    break;
            }
            return result;
        }
    }
}
