using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public  class DirectorPC
    {
        private readonly IBuilder _builder;

        public DirectorPC(IBuilder builder)
        {
            _builder = builder;
        }

        public void Build(Processor processor, Motherboard motherboard, RAM ram, Storage storage, GraphicCards graphicCards)
        {
            _builder.SetMotherboard(motherboard);
            _builder.SetProcessor(processor);
            _builder.SetStorage(storage);
            _builder.SetGCard(graphicCards);
            _builder.SetRAM(ram);
        }
    }
}
