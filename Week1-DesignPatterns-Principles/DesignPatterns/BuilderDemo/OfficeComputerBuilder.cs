public class OfficeComputerBuilder : ComputerBuilder
{
    public override void BuildCPU()
    {
        computer.CPU = "Intel Core i5";
    }

    public override void BuildRAM()
    {
        computer.RAM = "16 GB";
    }

    public override void BuildStorage()
    {
        computer.Storage = "512 GB SSD";
    }
}