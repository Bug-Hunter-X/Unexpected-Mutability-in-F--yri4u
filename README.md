# Unexpected Mutability in F#

This example demonstrates a common issue when working with mutable variables in F#.  The mutability of a variable can lead to unexpected behavior if not carefully managed. The example shows that when a function modifies a mutable variable, subsequent calls to the function will operate on the changed value.  This can be a source of subtle bugs, especially in more complex programs.

## Solution

The solution involves either avoiding mutable variables or managing them carefully to eliminate unexpected changes.