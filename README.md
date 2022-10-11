# C# Concepts
Repository to practice C# Concepts

These are the concepts that we practice here:
- [Virtual](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual) and [Override](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override) ([Abstract](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract) class) | [Notes](#virtual-override-and-abstract-modifiers)
- Generics (Methods and Classes)
- Extension Method
- Anonymous Method
- Anonymous Type
- Reflection

## Virtual Override and Abstract modifiers
### Virtual
This modifier allow us to override a method, property, indexer or event declaration in a derived class.
When we invoke a virtual method the compiler sets the run-time type of it until it has checked all overriding members.

### Override
This modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer or event.

* An override method provides a new implementation of the method inherited from a base class.
* The method that is overridden by an override declaration is known as the overridden base method.
* An override method must have the **same signature** as the overridden base method.

### Abstract
This modifier indicates that **the thing being modified has a missing or incomplete implementation**. The abstract modifier can be used with classes, methods, properties, indexers, and events.

#### Classes
* Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, not instantiated on its own.
* Members marked as abstract must be implemented by non-abstract classes that derive from the abstract class.

Abstract classes have the following features:
- An abstract class cannot be instantiated.
- An abstract class may contain abstract methods and accessors.
- A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.

Abstract Class and Interface:
* An abstract class must provide implementation for all interface members.
* An abstract class that implements an interface might map the interface methods onto abstract methods. 

#### Methods
Use the **abstract** modifier in a method or property declaration to indicate that the method or property does not contain implementation.

Abstract methods have the following features:

* An abstract method is implicitly a virtual method.
* Abstract method declarations are only permitted in abstract classes.

Because an abstract method declaration provides no actual implementation, there is no method body; the method declaration simply ends with a semicolon and there are no curly braces ({ }) following the signature.a
The implementation is provided by a method override, which is a member of a non-abstract class.