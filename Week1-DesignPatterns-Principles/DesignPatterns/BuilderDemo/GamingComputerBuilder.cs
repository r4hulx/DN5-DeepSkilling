public class GamingComputerBuilder : ComputerBuilder
{
    public override void BuildCPU()
    {
        computer.CPU = "Intel Core i9";
    }

    public override void BuildRAM()
    {
        computer.RAM = "32 GB";
    }

    public override void BuildStorage()
    {
        computer.Storage = "2 TB SSD";
    }
}