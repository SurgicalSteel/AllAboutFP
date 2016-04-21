// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
[<EntryPoint>]
let main argv = 
    let mutable inps=Console.ReadLine()
    let mutable build = ""
    let sz = String.length inps - 1
    let mutable hash = []
    let mutable curr =""
    for i = 0 to sz do
        curr<-inps.Substring(i,1)
        if not(List.exists(fun x ->x=curr) hash) then
            build<-build+curr
            hash<-curr::hash
    Console.WriteLine(build)
    Console.ReadLine()
    0 // return an integer exit code
