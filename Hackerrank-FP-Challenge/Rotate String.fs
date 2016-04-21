// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
[<EntryPoint>]

let main argv = 
    let tc = Console.ReadLine() |> int
    for i = 1 to tc  do
        let mutable str = Console.ReadLine()
        let mutable len = String.length str
        if len = 1 then Console.WriteLine(str)
        else
            for x = 0  to len-1 do
                let mutable a =str.Substring(0,1)
                let mutable b =str.Substring(1)
                str<-b+a
                Console.Write(str+" ")
            Console.WriteLine("")
    Console.ReadLine()
    0 // return an integer exit code
