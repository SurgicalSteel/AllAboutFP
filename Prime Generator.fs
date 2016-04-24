// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
[<EntryPoint>]
let main argv = 
    let sieve n =
        let checkprime x =
            let mutable ctr = 0
            for i=1 to x do
                if x%i = 0 then ctr <- ctr + 1
            if ctr>2 then 0 else 1
        for i = 2 to n do
            if checkprime(i)=1 then Console.WriteLine(i)    
    let mutable size = Console.ReadLine() |> int
    sieve(size)
    Console.ReadLine()
    0 // return an integer exit code
