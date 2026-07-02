# LSP (Liskov Substitution Principle)

## Objective
Demonstrate that derived classes should be replaceable for their base classes.

## Solution
Bird is the base class.

FlyingBird
- Sparrow

Non-flying Bird
- Penguin

This avoids forcing Penguin to implement Fly().

## Output

Bird is eating.
Flying...
Sparrow is chirping.

Bird is eating.
Penguin is swimming.