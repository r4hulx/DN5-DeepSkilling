IGUIFactory windowsFactory = new WindowsFactory();

IButton windowsButton = windowsFactory.CreateButton();
ICheckbox windowsCheckbox = windowsFactory.CreateCheckbox();

windowsButton.Render();
windowsCheckbox.Check();

Console.WriteLine();

IGUIFactory macFactory = new MacFactory();

IButton macButton = macFactory.CreateButton();
ICheckbox macCheckbox = macFactory.CreateCheckbox();

macButton.Render();
macCheckbox.Check();