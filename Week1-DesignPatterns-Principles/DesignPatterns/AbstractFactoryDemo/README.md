# Abstract Factory Pattern

## Objective

Create families of related objects without specifying their concrete classes.

## Real-World Examples

- Cross-platform UI (Windows / macOS)
- Database Drivers
- Theme Engines
- Game UI Components

## Files

- IButton.cs
- ICheckbox.cs
- IGUIFactory.cs
- WindowsButton.cs
- WindowsCheckbox.cs
- WindowsFactory.cs
- MacButton.cs
- MacCheckbox.cs
- MacFactory.cs
- Program.cs

## Expected Output

```
Windows Button Created
Windows Checkbox Checked

Mac Button Created
Mac Checkbox Checked
```