# SOLID Principles

## What is SOLID?

SOLID is a set of five object-oriented design principles that help developers write clean, maintainable, scalable, and loosely coupled software.

---

## 1. SRP – Single Responsibility Principle

A class should have only one reason to change.

**Example:**
A Report class should only generate reports.
Saving or printing the report should be handled by different classes.

---

## 2. OCP – Open Closed Principle

Software entities should be open for extension but closed for modification.

Instead of changing existing code, extend it using inheritance or interfaces.

---

## 3. LSP – Liskov Substitution Principle

A derived class should be replaceable by its base class without affecting correctness.

---

## 4. ISP – Interface Segregation Principle

Clients should not be forced to implement interfaces they do not use.

Create smaller, specific interfaces instead of one large interface.

---

## 5. DIP – Dependency Inversion Principle

High-level modules should depend on abstractions, not concrete implementations.

Use interfaces instead of directly creating objects.

---

# Quick Revision

| Principle | Meaning |
|-----------|---------|
| SRP | One Class = One Responsibility |
| OCP | Extend, Don't Modify |
| LSP | Child should replace Parent |
| ISP | Small Interfaces |
| DIP | Depend on Interfaces |
