using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceLocationModel.Utils
{
    static class DateTimeUtils
    {
        public static bool Overlap(DateTime begin1, DateTime end1, DateTime begin2, DateTime end2)
        {
            return (begin1 > begin2 && begin1 < end2)
                || (end1 > begin2 && end1 < end2)
                || (begin1 < begin2 && end1 > end2);
        }
    }
}
