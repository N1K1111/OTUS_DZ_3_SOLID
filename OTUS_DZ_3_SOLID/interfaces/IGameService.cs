using OTUS_DZ_3_SOLID.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ_3_SOLID.interfaces
{
    internal interface IGameService
    {
        void Execute(Settings set, int generatedNumber);
    }
}
