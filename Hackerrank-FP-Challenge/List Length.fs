open System
let mutable ctr=0
let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            ctr<-ctr+1
            buff <- Console.ReadLine()
    arr
let main =
    let mutable arr = read_and_parse()
    Console.WriteLine(ctr)
