### Separation of concerns

#### What is it?
Each application concern should have it's own place in the code base and should not overlap with other concerns.

Single responsibility principle (**S** in SOLID) applied at a larger scale.

##### Typical Example

ORM and Domain model 
- Ideally there should be no overlap between the domain model and the chosen ORM
- What would the domain model look like with no need for persistence?

