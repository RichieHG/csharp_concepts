# C# Concepts
Repository to practice C# Concepts

These are the concepts that we practice here:
- [Virtual](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual) and [Override](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override) ([Abstract](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract) class) | [Notes](#virtual-override-and-abstract-modifiers)
- [Generics](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics) ([Methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods) and [Classes](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-classes)) | [Notes](#generics)
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

## Generics
This concept allow us to improve our code reusability, because it introduce a kind of non-typed data into our code.

* Use generic types to maximize code reuse, type safety, and performance.
* The most common use of generics is to create collection classes.

Typically, you create generic classes by starting with an existing concrete class, and changing types into type parameters one at a time until you reach the optimal balance of generalization and usability.

## Extension Methods
Extension methods enable you to "add" methods to existing types without modifying the original type. This kind of methods are static methods, but they're called as if they were instance methods on the extended type.

Their first parameter specifies which type the method operates on. The parameter is preceded by the this modifier. Extension methods are only in scope when you explicitly import the namespace into your source code with a using directive. 

These methods can be invoked like other static methods

### To define and call the extension method
1. Define a static class to contain the extension method.
2. Implement the extension method as a static method with at least the same visibility as the containing class.
3. The first parameter of the method specifies the type that the method operates on; it must be preceded with the **this** modifier.
4. In the calling code, add a using directive to specify the namespace that contains the extension method class.
5. Call the methods as if they were instance methods on the type.

Note that the first parameter is not specified by calling code because it represents the type on which the operator is being applied, and the compiler already knows the type of your object. You only have to provide arguments for parameters 2 through n.

```
public static double MyOwnPower(this int number, int power) 
{
    double temp = 1;
    for(int i = 1; i<=power; i++)
    {
        temp = temp * number;
    }
    return temp;
}
```

```
private static void Main(string[] args)
{
    /*
    * Extension Method example
    */
    int number = 5;
    double numberPowered = number.MyOwnPower(3);

    //Method invoked like other static methods
    //double numberPowered = ExtensionMethods.MyOwnPower(number, 3);
    
    Console.WriteLine(numberPowered);

}
```