// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
let f arr =
    let len = List.length arr - 1
    let mutable arres = []
    let mutable ne = -1
    for i=int(len) downto 0 do
        if arr.[i] < 0 then
            let mutable tmp = arr.[i] * -1
            arres <- tmp::arres
        else arres <- arr.[i]::arres
    arres
let input = 
    stdin.ReadToEnd().Split '\n' 
    |> Array.map(fun x -> int(x)) 
    |> Array.toList
    
let print_out (data:int list) = List.iter (fun x -> printfn "%A" x) data

print_out (f(input))
//Console.ReadLine()
