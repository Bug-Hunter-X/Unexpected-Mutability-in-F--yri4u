let mutable x = 10

let addOne x = x + 1

let y = addOne x // y will be 11

x <- addOne x // x will be 11

let z = addOne x // z will be 12

printfn "%d %d %d" x y z // Output: 11 11 12

//The issue is that the value of x is mutated, so it changes between calls to addOne.
//If you were expecting y and z to both be 11, then this would be unexpected behavior.
//This can lead to difficult-to-track errors in more complex programs.