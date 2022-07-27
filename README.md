## Filter by Predicate. Inheritance

Intermediate level task for practicing partial classes and methods.

Estimated time to complete the task - 2h.

The task requires .NET 6 SDK installed.

## Task description ##

- Develop the [ArrayExtension](ArrayExtension) class with following methods:

    - the `FilterByDigit` method, which takes an array of integers as a parameter and, based on it, forms a new array only from those elements that contain the given digit;
    - the `FilterByPalindromic` method, which takes an array of integers as a parameter and, based on it, forms a new array only from those elements that are palindromes.    
    _When implementing these methods, follow the suggested patterns._

- Analyze the resulting methods:
    - what part of their code is the same?
    - which part depends on a specific _predicate_*?
    - how to change the class if it becomes necessary to add a method/methods with _additional conditions_ for filtering?

- To solve the above problem, develop an abstract `Filter` class that implements the logic for filtering array elements according to any given predicate.

- Develop derived classes `PalindromicFilter` and `ContainsDigitFilter` that implement logic for filtering array elements according to corresponding predicates. Place the solutions in two separate projects:

    - [Filter by Digit](FilerByDigit)
    - [Filter by Palindromic](FilterByPalindromic).

- Run all unit tests.

- Study [mock](http://xunitpatterns.com/Mock%20Object.html) tests and the [Moq](https://github.com/Moq/moq4/wiki/Quickstart) Framework.

- Suggest your custom version of the predicate and place it in separate project.

- Study the following class diagramm

    ![](/filter-by-predicate.png)

- Study the [Template Method](https://refactoring.guru/design-patterns/template-method) design pattern.

_*A `predicate`  is a statement made about a subject. The subject of the statement is that about which the statement is made. A predicate in programming is an expression that uses one or more values with a boolean result._
