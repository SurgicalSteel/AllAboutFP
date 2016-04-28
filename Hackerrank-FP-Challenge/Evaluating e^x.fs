open System
[<EntryPoint>]
let main argv = 
    let rec factorial (x) =
        if x=1 then 1
        else x*factorial(x-1)
    let rec power (num :float,exp) = 
        if exp=0 then float(1)
        else float(num*power(num,exp-1))
    let mutable n=Console.ReadLine() |> int
    for i=1 to n do
        let mutable din = float(Console.ReadLine())
        let mutable ctr :float =0.0
        let mutable x = 1
        while x <= 10 do
            if x=1 then ctr <- ctr + float(1)
            else if x = 2 then ctr <- ctr + din
            else ctr <- ctr + (power(din,x-1)/float(factorial(x-1)))
            x<- x+ 1
        Console.WriteLine("{0:F4}",ctr)
    0 
