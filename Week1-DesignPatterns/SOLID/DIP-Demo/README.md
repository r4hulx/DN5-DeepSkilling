# DIP (Dependency Inversion Principle)

## Objective
Demonstrate dependency on abstractions instead of concrete implementations.

## Solution
NotificationManager depends on the INotification interface.

Concrete implementations:
- EmailNotification
- SmsNotification

NotificationManager works with either implementation without modification.

## Output

Email sent successfully.

SMS sent successfully.