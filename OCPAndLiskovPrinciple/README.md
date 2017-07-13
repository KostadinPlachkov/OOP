## Table of Contents
1. OCP – Open / Closed Principle
2. Violations of OCP
3. LSP – Liskov Substitution Principle
4. Violations of LSP

## What is Open/Closed?
Software entities like classes, modules
and functions should be open for extension
but closed for modifications

## Open/Closed Principle (OCP)
* Design and writing of the code should be done in a way that
new functionality should be added with minimum changes in
the existing code
* Changes to source code are not required

## OCP – Violations
* Cascading changes through modules
* Each change requires re-testing
* Logic depends on conditional statements

## Liskov Substitution Principle (LSP)
Derived types must be completely substitutable for their base types
* Reference to the base class can be replaced with a derived class without affecting the functionality of the program module
* Derived classes just extend without replacing the functionality of old classes

## OCP vs LSP
Liskov Substitution Principle is just an
extension of the Open Close Principle and
it means that we must make sure that new
derived classes are extending the base
classes without changing their behavior.

## Summary
1. OCP – Open / Closed Principle
      * Violations of OCP
2. LSP – Liskov Substitution Principle
      * Violations of LSP
