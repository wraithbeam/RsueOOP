using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRsueOOP
{
    public class FindATS
    {
        int cityId;

        public FindATS(int cityId)
        {
            this.cityId = cityId;
        }

        public bool AtsFindPredicate(ATS ats)
        {
            return cityId == ats.IdCity;
        }
    }
}
