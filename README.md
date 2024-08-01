# Custom OneOf-Types with OneOfBase

This example:

* Converts text to the Discriminated Union 'IntOrDoubleOrText',
  which inherits from 'OneOfBase<int, double, string>' and
  which can store either an integer, a double or a string.

* Then prints the type of the value stored in the Discriminated Union.
