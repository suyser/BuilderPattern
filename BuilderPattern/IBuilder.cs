using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void SetMotherboard(Motherboard motherboard);
        void SetProcessor(Processor processor);
        void SetRAM(RAM rAM);
        void SetStorage(Storage storage);
        void SetGCard(GraphicCards graphicCards);

        Computer GetComputer();
    }
}
