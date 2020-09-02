### Encapsulation

#### What is it
The act of protecting data integrity.

Internal data can not be set to an inconsistent state

#### How?
- information hiding, remove class internals from the eyes of clients
- bundling operations together
  - single entry point for actions that are performed on the class
  - can verify **invariants** before (and after?) performing actions

#### Invariants
Conditions that must always be true.  Constrains the state stored in an object.  May be derived from business rules.