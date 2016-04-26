open System
[<EntryPoint>]
let main argv =
    let euclid (xa,ya,xb,yb) =
        Math.Sqrt(((xa-xb)*(xa-xb))+((ya-yb)*(ya-yb)))
    let mutable tc=Console.ReadLine()|>int
    let mutable arrx=Array.create tc 0
    let mutable arry=Array.create tc 0
    for x=1 to tc do
        let mutable read=Console.ReadLine().Split(' ')
        arrx.[x-1]<-int(read.[0])
        arry.[x-1]<-int(read.[1])
    let mutable res :float = 0.0
    for i=1 to tc-1 do
        res <- res + euclid(float(arrx.[i]),float(arry.[i]),float(arrx.[i-1]),float(arry.[i-1]))
    res <- res + euclid(float(arrx.[tc-1]),float(arry.[tc-1]),float(arrx.[0]),float(arry.[0]))
    Console.WriteLine("{0:F1}",res)
    Console.ReadLine()
    0 // return an integer exit code
