using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class BuilderPC : IBuilder
    {
        private Computer _computer;

        public BuilderPC()
        {
            _computer = new();
        }

        public void SetMotherboard(Motherboard motherboard)
        {
            _computer.Motherboard = motherboard.Model;
        }

        public void SetProcessor(Processor processor)
        {
            _computer.Processor = processor.Model;
        }

        public void SetRAM(RAM ram)
        {
            _computer.RAM = ram.Model;
        }

        public void SetStorage(Storage storage)
        {
            _computer.Storage = storage.Model;
        }

        public void SetGCard(GraphicCards graphicCard)
        {
            _computer.GCard = graphicCard.Model;
        }

        public Computer GetComputer()
        {
            Computer computer = _computer;
            _computer = new();

            return computer;
        }
    }
}
