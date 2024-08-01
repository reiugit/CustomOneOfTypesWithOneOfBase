using CustomOneOfTypesWithOneOfBase.Extensions;
using CustomOneOfTypesWithOneOfBase.Keyhandler;


// Convert text to Discriminated Union 'IntOrDoubleOrText',
// which inherits from 'OneOfBase<int, double, string>'
// and which can store either an integer, a double or a string.
// Then print the type of the value stored in the Discriminated Union.


"1.00".AsIntOrDoubleOrText()
      .PrintType();

"1.23".AsIntOrDoubleOrText()
      .PrintType();

"a.bc".AsIntOrDoubleOrText()
      .PrintType();


KeyHandler.WaitForKey();
