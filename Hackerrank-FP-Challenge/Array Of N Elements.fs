open System

let f n = //Complete this function
    let mutable arr = []
    for i=1 to n do
        arr<-i::arr
    arr
let main() =
    let input = Console.ReadLine()
    let n = int input
    printfn "%d" (f n).Length

 
main()
