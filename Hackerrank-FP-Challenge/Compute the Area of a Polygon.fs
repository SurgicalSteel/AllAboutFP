// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
[<EntryPoint>]
let main argv = 
    let mutable tc=Console.ReadLine() |> int
    let mutable arra=[]
    let mutable arrb=[]
    let mutable arrtemp = Array.empty
    for i=1 to tc do
        arrtemp <-Console.ReadLine().Split ' '
        arra <- int(arrtemp.[0])::arra
        arrb <- int(arrtemp.[1])::arrb
    let mutable suma=0
    let mutable sumb=0
    let mutable j = tc - 1
    let mutable area :float = 0.0
    for i=0 to tc - 1 do
        area <- area + float(((arra.[i]+arra.[j])*(arrb.[j]-(arrb.[i]))))
        j <- i
    area <-area/2.0
    Console.WriteLine("{0:F1}",area)
    Console.ReadLine() 
    0 // return an integer exit code
