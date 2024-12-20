let x = 10

let addOne x = x + 1

let y = addOne x // y will be 11

let z = addOne x // z will be 11

printfn "%d %d %d" x y z // Output: 10 11 11

//In this solution, x is an immutable value. It remains unchanged after each call to addOne. Therefore y and z are calculated based on the initial value of x
//This revised code is more predictable and easier to reason about.