## Filter by Predicate. Inheritance

Intermediate level task for practicing partial classes and methods.

Estimated time to complete the task - 2h.

The task requires .NET 6 SDK installed.

## Task description ##

- Develop the [ArrayExtension](ArrayExtension) class with following methods:

    - the `FilterByDigit` method that returns an array of integers whose elements contain a given digit;
    - the `FilterByPalindromic` method that returns an array of integers that are palindromes. 

- Analyze your methods: what part of the code can be made reusable and which part can be customizable depending on the specific way of matching the number with a certain _predicate_*?

- Develop abstract class `Filter` to implement logic for filtering array elements according to a predicate.

- Develop derived classes `PalindromicFilter` and `ContainsDigitFilter` that implement logic for filtering array elements according to corresponding predicates. Place the solutions in two separate projects:

    - [Filter by Digit](FilerByDigit)
    - [Filter by Palindromic](FilterByPalindromic).

    ![](/filter-by-predicate.png)

- Run all unit tests.

- Study [mock](http://xunitpatterns.com/Mock%20Object.html) tests and the [Moq](https://github.com/Moq/moq4/wiki/Quickstart) Framework.

- Suggest your custom version of the predicate and place it in separate project.

_*A `predicate`  is a statement made about a subject. The subject of the statement is that about which the statement is made. A predicate in programming is an expression that uses one or more values with a boolean result._
