// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
[<EntryPoint>]
let main argv = 
    let sz=int(Console.ReadLine())
    let siji = 1
    if sz = 1 then
        printf "1\n"
    else if sz = 2 then
        printf "1\n1 1\n"
    else 
        printf "1\n"
        printf "1 1\n"
        let mutable curarr = []
        let mutable arr = []
        let mutable ressum=0
        arr<-1::arr
        arr<-1::arr
        for i=3 to sz do
            for x=1 to i do
                if x=1 then
                    curarr <- 1::curarr
                    Console.Write("{0} ",1)
                else if x=i then
                    curarr <- 1::curarr
                    Console.Write("{0}",1)
                else 
                   ressum <-arr.[x-1]+arr.[x-2]
                   curarr <-ressum::curarr
                   Console.Write("{0} ",ressum)
            arr<-curarr
            Console.WriteLine()
    Console.ReadLine()
    0 // return an integer exit code
