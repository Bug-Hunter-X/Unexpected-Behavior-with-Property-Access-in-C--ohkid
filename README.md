# Unexpected Property Access Behavior in C#

This repository demonstrates a subtle but potentially problematic scenario in C# involving multiple accesses to a property within a single method.  The issue arises when the property's getter or setter has side effects beyond simple value retrieval or assignment.

The `bug.cs` file shows the problematic code.  The `bugSolution.cs` file offers a solution to prevent unintended multiple calls to the property accessor.

This issue highlights the importance of understanding how property accessors work and the potential implications of side effects in getter and setter methods.