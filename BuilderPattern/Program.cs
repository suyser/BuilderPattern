using BuilderPattern;

var builder = new BuilderPC();
var director = new DirectorPC(builder);


Processor processor = new("Intel");
Motherboard motherboard = new("MSI");
RAM ram = new("DDR5");
Storage storage = new("SSD 1Gb");
GraphicCards card = new("GeForce GTX 1050Ti");
director.Build(processor, motherboard, ram, storage, card);

var result = builder.GetComputer();

Console.WriteLine($"Материнская плата: {result.Motherboard}\n"
    +$"Процессор {result.Processor}\n"+
    $"Оперативная память: {result.RAM}\n" +
    $"Накопитель: {result.Storage}\n"+
    $"Видеокарта: {result.GCard}");