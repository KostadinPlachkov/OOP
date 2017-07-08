## Table of Contents
1. Enumerations
    * Defining Enumerated Types
    * Using Enumerated Types
2. Attributes
    * Applying Attributes to Code Elements
    * Built-in Attributes
    * Defining Attributes

## Custom Attributes Requirements
* Must inherit the System.Attribute class
* Their names must end with "Attribute"
* Possible targets must be defined via [AttributeUsage]
* Can define constructors with parameters
* Can define public fields and properties

## Summary
* Enumerations define a fixed set of constants
    * E.g. RGB colors
    * Are much like classes
    * Cannot be inherited
* Attributes allow adding metadata in classes / types / etc.
    * Built-in attributes
    * Custom attributes
    * Can be accessed at runtime
