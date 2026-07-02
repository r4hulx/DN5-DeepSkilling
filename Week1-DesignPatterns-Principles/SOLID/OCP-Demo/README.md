# OCP (Open/Closed Principle)

## Objective
Demonstrate how software should be open for extension but closed for modification.

## Problem
Adding a new shape should not require modifying existing calculation logic.

## Solution
Created an abstract Shape class.
Each shape implements its own Area() method.

Shapes implemented:
- Circle
- Rectangle
- Triangle

## Output

Circle Area
Rectangle Area
Triangle Area

## Files
- Shape.cs
- Circle.cs
- Rectangle.cs
- Triangle.cs
- AreaCalculator.cs
- Program.cs