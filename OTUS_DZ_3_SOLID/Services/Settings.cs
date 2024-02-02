using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ_3_SOLID.Services
{
    internal class Settings
    {
        internal int CountAttempts { get; set; }
        internal int MinNumber {  get; set; }
        internal int MaxNumber {  get; set; }

        public Settings(int countAttempts, int minNumber, int maxNumber)
        {
            CountAttempts = countAttempts;
            MinNumber = minNumber;
            MaxNumber = maxNumber;
        }
    }
}
