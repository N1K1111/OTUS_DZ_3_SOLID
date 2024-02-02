using OTUS_DZ_3_SOLID.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ_3_SOLID.Services
{
    internal class RandomGenerator : IGenerator
    {
        public int Generate(Settings settings)
        {
            Random random = new Random();
            int minNumber = settings.MinNumber;
            int maxNumber = settings.MaxNumber;
            return random.Next(minNumber,maxNumber);
        }
    }
}
