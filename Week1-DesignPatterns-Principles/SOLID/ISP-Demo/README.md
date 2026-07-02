# ISP (Interface Segregation Principle)

## Objective
Demonstrate that classes should not depend on interfaces they do not use.

## Solution
Separated interfaces into:

- IWork
- IEat

HumanWorker implements:
- IWork
- IEat

RobotWorker implements:
- IWork

This prevents RobotWorker from implementing unnecessary methods.

## Output

Human is working.
Human is eating.

Robot is working.