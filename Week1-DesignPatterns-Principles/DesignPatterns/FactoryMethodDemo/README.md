# Factory Method Pattern

## Objective

Demonstrate how object creation can be delegated to subclasses using the Factory Method Design Pattern, allowing client code to remain independent of concrete classes.

---

## Real-World Example

A notification system that can send notifications through different channels.

- Email Notification
- SMS Notification
- Push Notification

Instead of directly creating notification objects, a corresponding factory creates the required notification service.

---

## Files

- INotification.cs
- EmailNotification.cs
- SmsNotification.cs
- PushNotification.cs
- NotificationFactory.cs
- EmailFactory.cs
- SmsFactory.cs
- PushFactory.cs
- Program.cs

---

## Expected Output

```text
Email Sent: Welcome via Email!
SMS Sent: OTP Sent via SMS!
Push Notification Sent: New Offer Available!
```

---

## Advantages

- Encapsulates object creation.
- Follows the Open/Closed Principle.
- Makes code easier to extend.
- Reduces coupling between client code and concrete implementations.

---

## Pattern Type

**Creational Design Pattern**