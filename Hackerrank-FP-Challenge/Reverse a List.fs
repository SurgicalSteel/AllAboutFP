open System
let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr
let main =
    let mutable ls=read_and_parse()
    for i=0 to (List.length ls - 1) do
        Console.WriteLine(ls.[i])
