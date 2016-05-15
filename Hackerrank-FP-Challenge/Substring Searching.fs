open System
[<EntryPoint>]
let main argv = 
    let mutable tc=Console.ReadLine() |>int
    let mutable ss=""
    let mutable sd=""
    for i=1 to tc do
        ss<-Console.ReadLine()
        sd<-Console.ReadLine()
        if(ss.Contains(sd)) then Console.WriteLine("YES")
        else Console.WriteLine("NO")
    0 // return an integer exit code
