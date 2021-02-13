# SmartCOPDrinks

SmartCOP quick assessment of OOP skills, etc

> Author: Joshua Wren
> Date: 13 Feb 2021
> Title: DrinksOnMe

For those reading that are not assessors and are simply interested in the code and a look at Classes, OOP, C#, etc...
Once you take the code, you can run it via `dotnet run`.
Program.cs is where the pieces are out for show. The rest of the cs pages are where classes are created. Drink is the parent class,
and the other three are children classes of it.

---

-   THE ASSESSMENT:

The goal of this console application was to:

> demonstrate object-oriented skills
> demonstrate normal coding standards (naming conventions, etc)

The application needed to:

> display information about three drink types
> drink types:
> beer
> soda
> juice
> drink types must be derived from common drink object with base properties
> drink type base properties:
> name
> carbonated or not
> description
> juice must have string property indicating fruit it is made from
> beer must have alcohol content
> Add at least three drink types to a list or array
> one must display that it is Orange Juice, not carbonated; must be of juice typing
> one must display that it is Budweiser, carbonated, alcohol content; must be of beer typing
> one must display that it is Pepsi, carbonated, must be of soda typing
> List must be looped to output description of each drink
> Was allowed to include additional features

---

-   HOW I ACCOMPLISHED:

I completed all of the taskings stated above.
In addition, I separated each class out from each other and the program. Namespaces were utilized to have them connected.
I made the three required drinks through default constructors, then a few others through custom constructors from each class.
Classes and their properties/methods are Pascal Cased. Everything else follows camel casing conventions.

> INHERITANCE:
> The child classes (Juice, Soda, Beer) inherited various properties and methods (currently just the description) from the parent class Drink.
> Additionally, the child classes have hierarchical inheritance as they all belong to Drink, but are separate classes from each other.
> This could have been taken further by developing a solution with child class to the drinks, or making an overarching class called Consumables that would be a parent to Drink
> -- producing a multi-level inheritance.

> ABSTRACTION:
> The parent class Drink is hidden behind the child classes through the use of `abstract class Drink{}`. `abstract` keeps the Drink class from being accessed directly.
> One must create an instance of a child class. The child classes handle what information needs to go between itself and the Drink class.

> ENCAPSULATION:
> The properties and methods that are grouped together into a class are a form of encapsulation.
> The specifiers that proceed these properties and methods allow or disallow other classes from accessing them.
> Drink uses the protected specifier to allow only child classes access to its properties, furthering inheritance.
> Drink uses the internal specifier to allow child classes complete access to the Description method, such as overriding it.
> The child classes make use of protected specifier on their unique properties to keep them protected from manipulation.
> The child classes utilize public specifiers on the constructors so that the main program can allow instantiation of these classes.

> POLYMORPHISM:
> The Description() method is polymorphed from parent class to child classes. Each child class has a unique way of describing itself, exculding the Soda class.
