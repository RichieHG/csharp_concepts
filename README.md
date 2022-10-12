# C# Concepts
Repository to practice C# Concepts

These are the concepts that we practice here:
- Virtual and Override (Abstract class) | [Notes](#virtual-override-and-abstract-modifiers)
- Generics (Methods and Classes) | [Notes](#generics-methods-and-classes)
- Extension Methods | [Notes](#extension-methods)
- Anonymous Method | [Notes](#delegates)
- Anonymous Type | [Notes](#anonymous-types)
- Reflection

## Virtual Override and Abstract modifiers
### [Virtual](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual)
This modifier allow us to override a method, property, indexer or event declaration in a derived class.
When we invoke a virtual method the compiler sets the run-time type of it until it has checked all overriding members.

### [Override](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override)
This modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer or event.

* An override method provides a new implementation of the method inherited from a base class.
* The method that is overridden by an override declaration is known as the overridden base method.
* An override method must have the **same signature** as the overridden base method.

### [Abstract](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract)
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

## [Generics](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics) ([Methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods) and [Classes](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-classes))
This concept allow us to improve our code reusability, because it introduce a kind of non-typed data into our code.

* Use generic types to maximize code reuse, type safety, and performance.
* The most common use of generics is to create collection classes.

Typically, you create generic classes by starting with an existing concrete class, and changing types into type parameters one at a time until you reach the optimal balance of generalization and usability.

## [Extension Methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)
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

## [Delegates](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/)
A delegate is a type that represents references to methods with a particular parameter list (Signature) and return type. You can associate a delegate with any method with a compatible signature and return type. You can invoke (or call) the method through the delegate instance.

* Delegates are used to pass methods as arguments to other methods. 
* Event handlers are nothing more than methods that are invoked through delegates.
* Any method from any accessible class or struct that matches the delegate type can be assigned to the delegate.
* The method can be either static or an instance method. 
* This flexibility means you can programmatically change method calls, or plug new code into existing classes.
* Delegates can be chained together; for example, multiple methods can be called on a single event.
    * A delegate can call more than one method when invoked. This is referred to as **multicasting**. To add an extra method to the delegate's list of methods—the invocation list—simply requires adding two delegates using the addition or addition assignment operators ('+' or '+='). For example:

*This ability to refer to a method as a parameter makes delegates ideal for defining **callback methods***

### [Anonymous Methods](https://learn.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2010/0yw3tz5k(v=vs.100))

Anonymous methods enable you to omit the parameter list. This means that an anonymous method can be converted to delegates with a variety of signatures. This is not possible with [lambda expressions](https://learn.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2010/bb397687(v=vs.100)).

Creating anonymous methods is essentially a way to pass a code block as a delegate parameter. 

```
// Create a delegate.
delegate void Del(int x);

// Instantiate the delegate using an anonymous method.
Del d = delegate(int k) { /* ... */ };
```

By using anonymous methods, you reduce the coding overhead in instantiating delegates because you do not have to create a separate method.


### [Delegates vs Interfaces](https://learn.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2010/ms173173(v=vs.100))

Interfaces and delegates give us the possibility to design a class where we separate type declaration and implementation.

* An Interface can be inherited and implemented by any class or struct.
* A Delegate can be created for a methos on any class, as long the method fits for the delegate's signature.

#### When to use Delegates?

Use a delegate in the following circumstances:

* An eventing design pattern is used.
* It is desirable to encapsulate a static method.
* The caller has no need to access other properties, methods, or interfaces on the object implementing the method.
* Easy composition is desired.
* A class may need more than one implementation of the method.

#### When to use Interface?

Use an interface in the following circumstances:

* There is a group of related methods that may be called.
* A class only needs one implementation of the method.
* The class using the interface will want to cast that interface to other interface or class types.
* The method being implemented is linked to the type or identity of the class: for example, comparison methods.

## [Anonymous Types](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types)
This kind of types provides a way to encapsulate a set of read-only properties without the necesity to define a explicit type/class.

To create an anonymous type, you have to use *new* operator together with an object initializer.
It can contains one or more public read-only properties (it means you cannot change the values of them) and the expression that is used to initialize a property cannot be null, an anonymous function, or a pointer type.

* Typically, when you use an anonymous type to initialize a variable, you declare the variable as an implicitly typed local variable by using var.
* Anonymous types typically are used in the *select* clause of a query expression to return a subset of the properties from each object in the source sequence.
* The most common scenario is to initialize an anonymous type with properties from another type.
* If you don't specify member names in the anonymous type, the compiler gives the anonymous type members the same name as the property being used to initialize them. You provide a name for a property that's being initialized with an expression
* Anonymous types are class types that derive directly from object, and that cannot be cast to any type except object.
* Anonymous types support non-destructive mutation in the form of [with expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/with-expression). This enables you to create a new instance of an anonymous type where one or more properties have new values