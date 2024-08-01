# Custom OneOf-Types with OneOfBase

This example:

* Converts text to the Discriminated Union 'IntOrDoubleOrText',<br>
  which inherits from 'OneOfBase<int, double, string>' and<br>
  which can store either an integer, a double or a string.

* Then it prints the type of the value stored in the Discriminated Union.
