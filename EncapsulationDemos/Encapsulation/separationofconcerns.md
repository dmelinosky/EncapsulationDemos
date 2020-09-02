### Separation of concerns

#### What is it?
Each application concern should have it's own place in the code base and should not overlap with other concerns.

##### Typical Example

ORM and Domain model - ideally there should be no overlap between the domain model and the chosen ORM
What would the domain model look like with no need for persistence?