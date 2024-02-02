using OTUS_DZ_3_SOLID.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ_3_SOLID.Services
{
    internal class Binder : IBinder
    {
        public Settings Bind(string?[] data)
        {
            if (data is {Length:3 } && int.TryParse(data[0],out int attemts)
                && int.TryParse(data[1], out int min) 
                && int.TryParse(data[2], out int max))
            {
                return new Settings(attemts, min, max);
            }
            throw new ArgumentException("Введены неверные значения.");
        }
    }
}
