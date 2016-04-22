// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
[<EntryPoint>]
let main argv = 
    let mutable inp = Console.ReadLine()
    let mutable ctr = 0
    let mutable arr=[]
    let mutable len = String.length inp - 1
    let mutable i = 0
    while i < String.length inp do
        let mutable subs = inp.Substring(i,1)
        if ctr =26 then 
            i <- len
        if not(List.exists(fun x -> x=subs) arr) then
            ctr<- ctr + 1
            arr<-subs::arr
            i <- i + 1
        else i <- i + 1
    let mutable lenarr = List.length arr - 1
    for x = lenarr downto 0 do
        Console.Write("{0}",arr.[x])
    Console.ReadLine()
    0 // return an integer exit code
