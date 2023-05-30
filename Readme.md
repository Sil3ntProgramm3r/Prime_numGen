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
Run the benchmark on your machine and try to optimize your prime number generator. 
