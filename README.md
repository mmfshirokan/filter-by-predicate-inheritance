## Filter by Predicate. Inheritance

Intermediate level task for practicing partial classes and methods.

Estimated time to complete the task - 2h.

The task requires .NET 6 SDK installed.

## Task description ##

- Implement an `FilterByDigit` method that obtains an array of integers whose elements contain a given digit. Place solution in project [Filter by Digit](FilerByDigit). The task definition is given in the  XML-comments for this method. _Don't use LINQ_.

- Implement a `FilterByPalindromic` method that takes an array of integers and filters it in such a way that the output will be a new array consisting only of elements that are palindromes. Place solution in project [Filter by Digit](FilterByPalindromic). _Do not use LINQ queries and delegates_.  

- Analyze your solutions: what part of the code can be made reusable and which part can be customizable depending on the specific way of matching the number with a certain _predicate_*?

- Using the capabilities of the inheritance of the classes propose the option of allocating reusable code. Demonstrate the ability to use  with the above integer predicates. Place the solutions in two separate projects:

    - [Filter by Digit with Framework](FilerByDigitWithFramework);
    - [Filter by Palindromic with Framework](FilterByPalindromicWithFramework).

- Suggest your custom version of the predicate and place it in separate project.

_*A `predicate`  is a statement made about a subject. The subject of the statement is that about which the statement is made. A predicate in programming is an expression that uses one or more values with a boolean result._
