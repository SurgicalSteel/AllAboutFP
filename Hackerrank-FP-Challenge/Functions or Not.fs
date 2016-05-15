open System
open System.Collections.Generic
[<EntryPoint>]
let main argv = 
    let mutable n=Console.ReadLine() |>int
    let mutable truth :bool =false
    let mutable sz = 0
    for i=1 to n do
        sz<-Console.ReadLine() |>int
        truth<-true
        let dict = new Dictionary<string,string>()
        for x=1 to sz do
            let mutable arstr=Console.ReadLine().Split()
            if(dict.ContainsKey(arstr.[0]) && not(dict.Item(arstr.[0]).Equals(arstr.[1])))
            then truth<-false
            else dict.Add(arstr.[0],arstr.[1])
        if truth then Console.WriteLine("YES") else Console.WriteLine("NO")
    0 // return an integer exit code
