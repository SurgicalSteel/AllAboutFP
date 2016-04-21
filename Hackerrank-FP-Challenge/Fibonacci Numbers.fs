// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
let rec fib x =
    if x = 1 then 0
    else if x = 2 then 1
    else fib(x-1)+fib(x-2)
[<EntryPoint>]
let main argv = 
    let inp = int(Console.ReadLine())
    Console.WriteLine("{0} ",fib(inp))
    Console.ReadLine()
    0 // return an integer exit code
