open System
open System.Numerics
[<EntryPoint>]
let main argv = 
    let mutable tc = Console.ReadLine() |> int
    let mutable strin = ""
    for i=1 to tc do
        strin <- Console.ReadLine()
        let mutable arrin = strin.Split ' '
        let mutable maxi = Math.Max(int(arrin.[0]),int(arrin.[1]))
        let mutable mini = Math.Min(int(arrin.[0]),int(arrin.[1]))
        let mutable arres =[] 
        for x=1 to mini do
            if maxi%x=0 && mini%x=0 then
                arres <-x::arres
        Console.WriteLine(List.length arres)
    Console.ReadLine()
    0
