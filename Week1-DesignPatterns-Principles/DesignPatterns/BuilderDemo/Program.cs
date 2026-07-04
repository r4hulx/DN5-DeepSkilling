Director director = new Director();

Console.WriteLine("Gaming Computer");

ComputerBuilder gamingBuilder = new GamingComputerBuilder();
director.Construct(gamingBuilder);

Computer gamingPC = gamingBuilder.GetComputer();
gamingPC.ShowConfiguration();

Console.WriteLine();

Console.WriteLine("Office Computer");

ComputerBuilder officeBuilder = new OfficeComputerBuilder();
director.Construct(officeBuilder);

Computer officePC = officeBuilder.GetComputer();
officePC.ShowConfiguration();