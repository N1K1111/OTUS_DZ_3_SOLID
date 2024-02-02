using OTUS_DZ_3_SOLID.interfaces;
using OTUS_DZ_3_SOLID.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ_3_SOLID
{
    internal class Game
    {
        internal IGenerator Generator;
        internal IBinder Binder;
        internal IReader Reader;
        internal IGameService GameService;

        public Game(IGenerator generator, IBinder binder, IReader reader, IGameService gameService)
        {
            Generator = generator;
            Binder = binder;
            Reader = reader;
            GameService = gameService;
        }

        public void Start()
        {
            string?[] data = Reader.Read();
            Settings set = Binder.Bind(data);
            int genNumber = Generator.Generate(set);
            GameService.Execute(set, genNumber);

        }
    }
}
