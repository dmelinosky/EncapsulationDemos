### Why

#### Reduce Complexity

Growth in complexity is a big concern, makes it hard to work with code.  Producivity drops.

Comples code is more prone to bugs.

#### Reduce Coupling

Complexity emerges from coupling
 - can lead to exponential growth in complexity as classes are coupled to other classes
 - new classes that are introduced also get coupled
 - devolves into a 'big ball of mud'

##### Decoupling
The number of code elements remains the same, but the number of connections between them is reduced

Divide code elements into buckets
- within a bucket, the elements can be tightly coupled
- buckets are loosely coupled to other buckets
- in buckets, reduce the complexity by removing internal coupling by reducing the surface area of the internal API

Decouple the Domain Model from the ORM

#### Source

[DDD and EF Core: Preserving Encapsulation](https://app.pluralsight.com/library/courses/ddd-ef-core-preserving-encapsulation/table-of-contents) by Vladimir Khorikov