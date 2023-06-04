# C# Prime Number Generator Enterprise Edition

## Features

-   Finds All Prime numbers between 0 and user input.
    -   Second level of indentation.
-   Used for Teaching C#.
-   Sandbox to improve speed.
-   Benchmarking exploration.
-   Creating Markdown readme files.
```csharp
// Example code in readme
var x=2;
int y=1;
int z=x+y;
```

```rust
// Example code in readme
let x:i32=2;// Types in rust can be optional if the compiler can figure it out. 
let y=1;
let z=x+y;
```


My benchmark results for method 1

| Method | Mean | Error | StdDev | Gen0 | Allocated |
| -------- | ---------:| --------:| --------:| -------:| ----------:|
| Method1 | 163.2 us | 0.89 us | 0.83 us | 0.9766 | 16.25 KB |

We need to speed it up. Any ideas?

### Next Task
Programs can be evaluated in multiple ways.
Memory footprint: How much RAM it uses.
Performance: How fast can the program finish a specific task.
Efficiency: how many computations needed to perform a task.

Readability of the program is often much more important than its performance (at least the high level). Performance is important too but oftentimes it is only needed for lower level details at the expense of readability. Most other times  you don't need to sacrifice readability. 

Questions to answer:
1-When you say it uses less CPU does that mean it is more performant? 
2-When two programs do the same task and one does it faster with more CPU and the other does it slower with less cpu which one is more performant?
3-Which of the two programs mentioned in question 2 is more efficient?
4-Did you read the comments and do you understand why nullable types are useful?

Tasks: 
1-Watch https://www.youtube.com/watch?v=SFv8Wm2HdNM and let me know what parts do you find useful.
2-Run the benchmark on your machine and determine which implementation is more performant and which is more memory efficient. 
3-Try to provide an explanation on why your PrintPrimeNumbers was taking less CPU.
4-Try to optimize your prime number generator in a thir function and add that function to the benchmark.

