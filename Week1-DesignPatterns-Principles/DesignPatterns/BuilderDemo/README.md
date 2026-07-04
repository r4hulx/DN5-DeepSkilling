# Builder Pattern

## Objective

Separate the construction of a complex object from its representation so the same construction process can create different objects.

## Real-World Example

Building different types of computers.

- Gaming Computer
- Office Computer

## Files

- Computer.cs
- ComputerBuilder.cs
- GamingComputerBuilder.cs
- OfficeComputerBuilder.cs
- Director.cs
- Program.cs

## Expected Output

```
Gaming Computer
CPU     : Intel Core i9
RAM     : 32 GB
Storage : 2 TB SSD

Office Computer
CPU     : Intel Core i5
RAM     : 16 GB
Storage : 512 GB SSD
```